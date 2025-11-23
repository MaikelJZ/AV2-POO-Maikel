using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace AV2_POO_Maikel
{
    public partial class FormCadastros : Form
    {
        //Atributos para interação
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter dataAdapter;

        string connectionString;
        int id = 0;
        public FormCadastros()
        {
            InitializeComponent();

            connectionString = @"Server=127.0.0.1;
                                Database=Financeiro;
                                Uid=root;
                                Pwd=mysql;";
            connection = new MySqlConnection(connectionString);
            ExibirGastos();
        }

        private void ExibirGastos()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException mex)
            {
                MessageBox.Show(mex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

                var dataTable = new DataTable();

                var query = "SELECT * FROM Gastos";

                dataAdapter = new MySqlDataAdapter(query, connection);

                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void LimparCampos()
        {
            id = 0;
            textBoxValor.Text = String.Empty;
            textBoxFormaPagamento.Text = "";
            maskedTextBoxData.Text = "";
            textBoxDescrição.Text = "";
            textBoxValor.Focus();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // verifica se já existe uma janela aberta do FormCadastros
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FormCadastros)
                {
                    frm.BringToFront();  
                    return;              
                }
            }

            // se não existir, cria um novo
            FormCadastros f = new FormCadastros();
            f.Show();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FormVisualizar)
                {
                    frm.BringToFront();  
                    return;              
                }
            }

            
            FormVisualizar f = new FormVisualizar();
            f.Show();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxValor.Text.Trim() != string.Empty &&
                    (textBoxFormaPagamento.Text.Trim() != string.Empty ||
                    textBoxDescrição.Text.Trim() != string.Empty ||
                    maskedTextBoxData.Text.Trim() != string.Empty))
                {
                    string query = "INSERT INTO Gastos (Valor, Data, FormaPagamento, Descricao) VALUES (@valor, @data, @formapagamento, @descricao )";

                    connection.Open();

                    command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@valor", textBoxValor.Text.Trim());
                    command.Parameters.AddWithValue("@formapagamento", textBoxFormaPagamento.Text.Trim());
                    command.Parameters.AddWithValue("@descricao", textBoxDescrição.Text.Trim());
                    if (!DateTime.TryParse(maskedTextBoxData.Text.Trim(), out DateTime data))
                    {
                        MessageBox.Show("Digite uma data válida para 'Data da Compra'.");
                        return;
                    }
                    command.Parameters.AddWithValue("@data", data);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cadastrado com SUCESSO...");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar, verifique os dados informados...");
                    }
                }
                else
                {
                    MessageBox.Show("O valor é obrigatório e deve ser preenchido ao menos um dos outros campos!");

                    textBoxValor.Focus();
                }
            }
            catch (MySqlException mex)
            {
                MessageBox.Show(mex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ExibirGastos();
                LimparCampos();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                textBoxValor.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                maskedTextBoxData.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxFormaPagamento.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxDescrição.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            {
                if (id == 0)
                {
                    MessageBox.Show("Selecione o registro que deseja excluir!!!");
                    return;
                }

                if (MessageBox.Show("Confirma a exclusão do registro Selecionado?",
                    "Cadastro de Gastos",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    MessageBox.Show("Exclusão Cancelada...");
                    LimparCampos();
                    return;
                }

                try
                {

                    var query = @"DELETE from Gastos where ID = @id;";

                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Excluído com SUCESSO...");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir, verifique os dados informados...");
                    }
                }
                catch (MySqlException npex)
                {
                    MessageBox.Show(npex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    ExibirGastos();
                    LimparCampos();
                }
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Selecione um registro para atualizar!");
                    return;
                }

                // VALOR obrigatório
                string valorTexto = textBoxValor.Text.Trim();
                if (string.IsNullOrWhiteSpace(valorTexto))
                {
                    MessageBox.Show("O campo VALOR é obrigatório!");
                    textBoxValor.Focus();
                    return;
                }

                // Tenta converter o valor usando a cultura pt-BR (aceita vírgula)
                decimal valorDecimal;
                var culture = new CultureInfo("pt-BR");
                if (!decimal.TryParse(valorTexto, NumberStyles.Number, culture, out valorDecimal))
                {
                    MessageBox.Show("Valor inválido. Use formato 60,00 ou 60.00.");
                    textBoxValor.Focus();
                    return;
                }

                // Verifica se pelo menos um dos outros campos foi preenchido
                if (string.IsNullOrWhiteSpace(textBoxDescrição.Text) &&
                    string.IsNullOrWhiteSpace(textBoxFormaPagamento.Text) &&
                    string.IsNullOrWhiteSpace(maskedTextBoxData.Text))
                {
                    MessageBox.Show("Preencha ao menos um dos outros campos!");
                    return;
                }

                string query = @"UPDATE Gastos 
                         SET Valor = @valor, 
                             Data = @data, 
                             FormaPagamento = @formapagamento, 
                             Descricao = @descricao 
                         WHERE ID = @id;";

                connection.Open();

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                    // envia o valor como decimal (não string)
                    cmd.Parameters.Add("@valor", MySqlDbType.Decimal).Value = valorDecimal;

                    cmd.Parameters.AddWithValue("@descricao", textBoxDescrição.Text.Trim());
                    cmd.Parameters.AddWithValue("@formapagamento", textBoxFormaPagamento.Text.Trim());

                    // converter data para formato aceito — ou enviar DateTime se a coluna for date/datetime
                    if (!string.IsNullOrWhiteSpace(maskedTextBoxData.Text))
                    {
                        if (DateTime.TryParseExact(maskedTextBoxData.Text.Trim(),
                                                   new[] { "dd/MM/yyyy", "d/M/yyyy", "yyyy-MM-dd" },
                                                   CultureInfo.GetCultureInfo("pt-BR"),
                                                   DateTimeStyles.None,
                                                   out DateTime data))
                        {
                            // se coluna é DATE/DATETIME, envie DateTime
                            cmd.Parameters.Add("@data", MySqlDbType.Date).Value = data;
                        }
                        else
                        {
                            MessageBox.Show("Data inválida. Use dd/MM/yyyy.");
                            return;
                        }
                    }
                    else
                    {
                        // se quiser permitir NULL quando vazio:
                        cmd.Parameters.Add("@data", MySqlDbType.Date).Value = DBNull.Value;
                    }

                    int linhas = cmd.ExecuteNonQuery();
                    if (linhas > 0)
                        MessageBox.Show("Atualizado com SUCESSO!");
                    else
                        MessageBox.Show("Erro ao atualizar, verifique os dados informados...");
                }
            }
            catch (MySqlException mex)
            {
                MessageBox.Show("Erro no MySQL: " + mex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                ExibirGastos();
                LimparCampos();
            }
        }

    }
}


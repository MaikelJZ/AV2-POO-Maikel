using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV2_POO_Maikel
{
    public partial class FormVisualizar : Form
    {
        //Atributos para interação
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter dataAdapter;

        string connectionString;
        public FormVisualizar()
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

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // verifica se já existe uma janela aberta do FormCadastros
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FormCadastros)
                {
                    frm.BringToFront();  // traz a janela para frente
                    return;              // impede abrir outra
                }
            }

            // se não existir, cria um novo
            FormCadastros f = new FormCadastros();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxPesquisa.Text))
                {
                    string query = "SELECT * FROM Gastos WHERE LOWER(Descricao) LIKE LOWER(@desc);";
                    string pesquisa = textBoxPesquisa.Text;

                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@desc", "%" + pesquisa + "%");

                        DataTable dataTable = new DataTable();

                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                        {
                            dataAdapter.Fill(dataTable);
                        }

                        dataGridView1.DataSource = dataTable;
                    }
                }
                else
                {
                    MessageBox.Show("O Campo de Pesquisa é obrigatório preencher");
                    textBoxPesquisa.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

namespace AV2_POO_Maikel
{
    partial class FormCadastros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastros));
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            buttonConfirmar = new Button();
            buttonExcluir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxValor = new TextBox();
            textBoxFormaPagamento = new TextBox();
            textBoxDescrição = new TextBox();
            maskedTextBoxData = new MaskedTextBox();
            buttonAtualizar = new Button();
            dataGridView1 = new DataGridView();
            Valor = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            FormaPagamento = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SeaGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, visualizarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(742, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(89, 25);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(89, 25);
            visualizarToolStripMenuItem.Text = "Visualizar";
            visualizarToolStripMenuItem.Click += visualizarToolStripMenuItem_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.BackColor = Color.ForestGreen;
            buttonConfirmar.FlatAppearance.BorderColor = Color.Black;
            buttonConfirmar.FlatAppearance.BorderSize = 2;
            buttonConfirmar.Location = new Point(29, 267);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(88, 50);
            buttonConfirmar.TabIndex = 2;
            buttonConfirmar.Text = "CONFIRMAR";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.DarkRed;
            buttonExcluir.FlatAppearance.BorderColor = Color.Black;
            buttonExcluir.FlatAppearance.BorderSize = 2;
            buttonExcluir.Location = new Point(133, 267);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(88, 50);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "EXCLUIR";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(29, 98);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 4;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(29, 138);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 5;
            label2.Text = "Forma de Pagamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 193);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(29, 178);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 7;
            label4.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(29, 214);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 8;
            label5.Text = "Data da Compra";
            // 
            // textBoxValor
            // 
            textBoxValor.Font = new Font("Segoe UI", 12F);
            textBoxValor.Location = new Point(217, 96);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.PlaceholderText = "R$00,00";
            textBoxValor.Size = new Size(100, 29);
            textBoxValor.TabIndex = 9;
            // 
            // textBoxFormaPagamento
            // 
            textBoxFormaPagamento.Font = new Font("Segoe UI", 12F);
            textBoxFormaPagamento.Location = new Point(217, 136);
            textBoxFormaPagamento.Name = "textBoxFormaPagamento";
            textBoxFormaPagamento.PlaceholderText = "Ex: Pix";
            textBoxFormaPagamento.Size = new Size(214, 29);
            textBoxFormaPagamento.TabIndex = 10;
            // 
            // textBoxDescrição
            // 
            textBoxDescrição.Font = new Font("Segoe UI", 12F);
            textBoxDescrição.Location = new Point(217, 174);
            textBoxDescrição.Name = "textBoxDescrição";
            textBoxDescrição.PlaceholderText = "Ex: Compras no Mercado";
            textBoxDescrição.Size = new Size(338, 29);
            textBoxDescrição.TabIndex = 11;
            // 
            // maskedTextBoxData
            // 
            maskedTextBoxData.Font = new Font("Segoe UI", 12F);
            maskedTextBoxData.Location = new Point(217, 210);
            maskedTextBoxData.Mask = "00/00/0000";
            maskedTextBoxData.Name = "maskedTextBoxData";
            maskedTextBoxData.Size = new Size(80, 29);
            maskedTextBoxData.TabIndex = 13;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.BackColor = SystemColors.ActiveCaption;
            buttonAtualizar.Location = new Point(238, 267);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(88, 50);
            buttonAtualizar.TabIndex = 14;
            buttonAtualizar.Text = "ATUALIZAR";
            buttonAtualizar.UseVisualStyleBackColor = false;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Desktop;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Valor, Column2, Column3, FormaPagamento, Column1 });
            dataGridView1.Location = new Point(29, 360);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(675, 273);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 70;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.DataPropertyName = "Data";
            Column2.HeaderText = "Data ";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 59;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ID";
            Column3.HeaderText = "Id";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // FormaPagamento
            // 
            FormaPagamento.DataPropertyName = "FormaPagamento";
            FormaPagamento.HeaderText = "Forma de Pagamento";
            FormaPagamento.Name = "FormaPagamento";
            FormaPagamento.ReadOnly = true;
            FormaPagamento.Width = 144;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "Descricao";
            Column1.HeaderText = "Descrição";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(29, 44);
            label6.Name = "label6";
            label6.Size = new Size(218, 32);
            label6.TabIndex = 16;
            label6.Text = "Cadastro de Gastos";
            // 
            // FormCadastros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(742, 672);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAtualizar);
            Controls.Add(maskedTextBoxData);
            Controls.Add(textBoxDescrição);
            Controls.Add(textBoxFormaPagamento);
            Controls.Add(textBoxValor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonConfirmar);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormCadastros";
            Text = "Financeiro";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private Button buttonConfirmar;
        private Button buttonExcluir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxValor;
        private TextBox textBoxFormaPagamento;
        private TextBox textBoxDescrição;
        private MaskedTextBox maskedTextBoxData;
        private Button buttonAtualizar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn FormaPagamento;
        private DataGridViewTextBoxColumn Column1;
        private Label label6;
    }
}
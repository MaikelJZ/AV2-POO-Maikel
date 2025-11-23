namespace AV2_POO_Maikel
{
    partial class FormVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizar));
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Valor = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            FormaPagamento = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBoxPesquisa = new TextBox();
            button1 = new Button();
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
            menuStrip1.Size = new Size(800, 29);
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
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Desktop;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Valor, Column2, Column3, FormaPagamento, Column1 });
            dataGridView1.Location = new Point(65, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(675, 273);
            dataGridView1.TabIndex = 16;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(65, 72);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 17;
            label1.Text = "Pesquisa Por Descrição";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Segoe UI", 12F);
            textBoxPesquisa.Location = new Point(234, 68);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.PlaceholderText = "Ex: Roupas";
            textBoxPesquisa.Size = new Size(312, 29);
            textBoxPesquisa.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(552, 68);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 19;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormVisualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxPesquisa);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormVisualizar";
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn FormaPagamento;
        private DataGridViewTextBoxColumn Column1;
        private Label label1;
        private TextBox textBoxPesquisa;
        private Button button1;
    }
}
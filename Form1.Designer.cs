namespace AV2_POO_Maikel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SeaGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, visualizarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1257, 29);
            menuStrip1.TabIndex = 0;
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
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(326, 274);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(640, 183);
            label1.TabIndex = 1;
            label1.Text = "Bem Vindo ao seu aplicativo de controle de gastos financeiros, onde será possivel visualizar e guardar todos os gastos do seu dia a dia.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Location = new Point(316, 257);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 211);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Design_sem_nome;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1257, 719);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Financeiro";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private Label label1;
        private Panel panel1;
    }
}

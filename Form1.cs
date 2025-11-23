using System.ComponentModel;

namespace AV2_POO_Maikel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class LabelComBorda : Label
        {
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public Color BorderColor { get; set; } = Color.Red;
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)
            public int BorderSize { get; set; } = 2;

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                using (Pen p = new Pen(BorderColor, BorderSize))
                {
                    e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
                }
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

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // verifica se já existe uma janela aberta do FormCadastros
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FormVisualizar)
                {
                    frm.BringToFront();  // traz a janela para frente
                    return;              // impede abrir outra
                }
            }

            // se não existir, cria um novo
            FormVisualizar f = new FormVisualizar();
            f.Show();
        }
    }
}

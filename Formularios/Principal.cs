using System;
using System.Windows.Forms;

namespace CatCafe
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            var escolha = MessageBox.Show(text: "Alo", caption: "Título mt poggers", buttons: MessageBoxButtons.YesNoCancel);

            if (escolha == DialogResult.Yes)
            {
                MessageBox.Show("Escolheu sim");
            }
            else if (escolha == DialogResult.No)
            {
                MessageBox.Show("Escolheu não");
            }
            else if (escolha == DialogResult.Cancel)
            {
                MessageBox.Show("Escolheu cancelou");
            }
        }
    }
}

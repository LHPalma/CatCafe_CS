using CatCafe.Classes;
using System;
using System.Windows.Forms;

namespace CatCafe.forms
{
    
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Btn_logar_Click(object sender, EventArgs e)
        {
            if (!EstaPreenchido())
            {
                Alertas.PreenchaTodosOsCampos();
                Txt_usuario.Focus();
                return;
            }


            this.Hide();
            Frm_principal frm_Principal = new Frm_principal();
            frm_Principal.ShowDialog();
            this.Dispose();
            this.Close();

        }

        private void Frm_login_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_logar.Cursor = EstaPreenchido() ? Cursors.Hand : Cursors.No;
        }

        private void Chk_mostrar_senha_CheckedChanged(object sender, EventArgs e)
        {
            Txt_senha.PasswordChar = Chk_mostrar_senha.Checked ? '\0' : '•';
        }

        private void Lb_usuario_Click(object sender, EventArgs e)
        {
            Txt_usuario.Focus();
        }

        private void Lb_senha_Click(object sender, EventArgs e)
        {
            Txt_senha.Focus();
        }


        #region FUNÇÕES

        private bool EstaPreenchido()
        {
            if (Txt_senha.Text == "" || Txt_usuario.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        #endregion FUNÇÕES
    }
}

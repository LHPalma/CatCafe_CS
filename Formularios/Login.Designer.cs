namespace CatCafe.forms
{
    partial class Frm_login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_senha = new System.Windows.Forms.Label();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Lb_usuario = new System.Windows.Forms.Label();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Btn_logar = new System.Windows.Forms.Button();
            this.Chk_mostrar_senha = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lb_senha);
            this.panel1.Controls.Add(this.Txt_senha);
            this.panel1.Controls.Add(this.Lb_usuario);
            this.panel1.Controls.Add(this.Txt_usuario);
            this.panel1.Controls.Add(this.Btn_logar);
            this.panel1.Controls.Add(this.Chk_mostrar_senha);
            this.panel1.Location = new System.Drawing.Point(39, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 164);
            this.panel1.TabIndex = 0;
            // 
            // Lb_senha
            // 
            this.Lb_senha.AutoSize = true;
            this.Lb_senha.Location = new System.Drawing.Point(32, 50);
            this.Lb_senha.Name = "Lb_senha";
            this.Lb_senha.Size = new System.Drawing.Size(38, 13);
            this.Lb_senha.TabIndex = 9;
            this.Lb_senha.Text = "Senha";
            this.Lb_senha.Click += new System.EventHandler(this.Lb_senha_Click);
            // 
            // Txt_senha
            // 
            this.Txt_senha.Location = new System.Drawing.Point(3, 70);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.PasswordChar = '•';
            this.Txt_senha.Size = new System.Drawing.Size(100, 20);
            this.Txt_senha.TabIndex = 8;
            // 
            // Lb_usuario
            // 
            this.Lb_usuario.AutoSize = true;
            this.Lb_usuario.Location = new System.Drawing.Point(32, 4);
            this.Lb_usuario.Name = "Lb_usuario";
            this.Lb_usuario.Size = new System.Drawing.Size(43, 13);
            this.Lb_usuario.TabIndex = 7;
            this.Lb_usuario.Text = "Usuário";
            this.Lb_usuario.Click += new System.EventHandler(this.Lb_usuario_Click);
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(3, 24);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.Txt_usuario.TabIndex = 6;
            // 
            // Btn_logar
            // 
            this.Btn_logar.Location = new System.Drawing.Point(3, 128);
            this.Btn_logar.Name = "Btn_logar";
            this.Btn_logar.Size = new System.Drawing.Size(104, 27);
            this.Btn_logar.TabIndex = 3;
            this.Btn_logar.Text = "Logar";
            this.Btn_logar.UseVisualStyleBackColor = true;
            this.Btn_logar.Click += new System.EventHandler(this.Btn_logar_Click);
            // 
            // Chk_mostrar_senha
            // 
            this.Chk_mostrar_senha.AutoSize = true;
            this.Chk_mostrar_senha.Location = new System.Drawing.Point(8, 96);
            this.Chk_mostrar_senha.Name = "Chk_mostrar_senha";
            this.Chk_mostrar_senha.Size = new System.Drawing.Size(95, 17);
            this.Chk_mostrar_senha.TabIndex = 2;
            this.Chk_mostrar_senha.Text = "Mostrar Senha";
            this.Chk_mostrar_senha.UseVisualStyleBackColor = true;
            this.Chk_mostrar_senha.CheckedChanged += new System.EventHandler(this.Chk_mostrar_senha_CheckedChanged);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 262);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_login";
            this.Text = "Login";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_login_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_logar;
        private System.Windows.Forms.CheckBox Chk_mostrar_senha;
        private System.Windows.Forms.Label Lb_senha;
        private System.Windows.Forms.TextBox Txt_senha;
        private System.Windows.Forms.Label Lb_usuario;
        private System.Windows.Forms.TextBox Txt_usuario;
    }
}
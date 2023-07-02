
namespace ListIt
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lbl_chamaForm = new System.Windows.Forms.LinkLabel();
            this.btn_limpar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_entrar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_senha = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_usuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Controls.Add(this.lbl_chamaForm);
            this.gunaGroupBox1.Controls.Add(this.btn_limpar);
            this.gunaGroupBox1.Controls.Add(this.btn_entrar);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.txt_senha);
            this.gunaGroupBox1.Controls.Add(this.txt_usuario);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(275, 50);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(402, 372);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "List It";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(170, 8);
            // 
            // lbl_chamaForm
            // 
            this.lbl_chamaForm.AutoSize = true;
            this.lbl_chamaForm.LinkColor = System.Drawing.Color.Navy;
            this.lbl_chamaForm.Location = new System.Drawing.Point(58, 340);
            this.lbl_chamaForm.Name = "lbl_chamaForm";
            this.lbl_chamaForm.Size = new System.Drawing.Size(305, 22);
            this.lbl_chamaForm.TabIndex = 6;
            this.lbl_chamaForm.TabStop = true;
            this.lbl_chamaForm.Text = "Não possui cadastro? Cadastre-se aqui";
            this.lbl_chamaForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_chamaForm_LinkClicked);
            // 
            // btn_limpar
            // 
            this.btn_limpar.AnimationHoverSpeed = 0.07F;
            this.btn_limpar.AnimationSpeed = 0.03F;
            this.btn_limpar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_limpar.BorderColor = System.Drawing.Color.Black;
            this.btn_limpar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_limpar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_limpar.CheckedForeColor = System.Drawing.Color.White;
            this.btn_limpar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_limpar.CheckedImage")));
            this.btn_limpar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_limpar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_limpar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_limpar.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Image = null;
            this.btn_limpar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_limpar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_limpar.Location = new System.Drawing.Point(237, 280);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_limpar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_limpar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_limpar.OnHoverImage = null;
            this.btn_limpar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_limpar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_limpar.Size = new System.Drawing.Size(126, 45);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.AnimationHoverSpeed = 0.07F;
            this.btn_entrar.AnimationSpeed = 0.03F;
            this.btn_entrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_entrar.BorderColor = System.Drawing.Color.Black;
            this.btn_entrar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_entrar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_entrar.CheckedForeColor = System.Drawing.Color.White;
            this.btn_entrar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_entrar.CheckedImage")));
            this.btn_entrar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_entrar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_entrar.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Image = null;
            this.btn_entrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_entrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_entrar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_entrar.Location = new System.Drawing.Point(35, 280);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_entrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_entrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_entrar.OnHoverImage = null;
            this.btn_entrar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_entrar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_entrar.Size = new System.Drawing.Size(126, 45);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Location = new System.Drawing.Point(162, 186);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(80, 26);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "SENHA:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(150, 71);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(101, 26);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "USUÁRIO:";
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_senha.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_senha.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.Color.Black;
            this.txt_senha.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_senha.Location = new System.Drawing.Point(80, 215);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.SelectedText = "";
            this.txt_senha.Size = new System.Drawing.Size(247, 36);
            this.txt_senha.TabIndex = 1;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usuario.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_usuario.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_usuario.Location = new System.Drawing.Point(80, 100);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PasswordChar = '\0';
            this.txt_usuario.SelectedText = "";
            this.txt_usuario.Size = new System.Drawing.Size(247, 36);
            this.txt_usuario.TabIndex = 0;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 483);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List It";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txt_senha;
        private Guna.UI.WinForms.GunaLineTextBox txt_usuario;
        private System.Windows.Forms.LinkLabel lbl_chamaForm;
        private Guna.UI.WinForms.GunaAdvenceButton btn_limpar;
        private Guna.UI.WinForms.GunaAdvenceButton btn_entrar;
    }
}
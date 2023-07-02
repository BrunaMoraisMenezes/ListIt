
namespace ListIt
{
    partial class frm_cadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastroUsuario));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_nome = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_email = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_senha = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_data = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btn_cadastrar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btn_limpar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txt_celular = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(49, 71);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(73, 26);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Nome:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Location = new System.Drawing.Point(438, 231);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(81, 26);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Celular:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaLabel3.Location = new System.Drawing.Point(49, 150);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(73, 26);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "E-mail:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaLabel4.Location = new System.Drawing.Point(49, 231);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(202, 26);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Data de Nascimento:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaLabel5.Location = new System.Drawing.Point(49, 313);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(73, 26);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Senha:";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.White;
            this.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nome.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_nome.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.Black;
            this.txt_nome.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_nome.Location = new System.Drawing.Point(160, 61);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(578, 36);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_email.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_email.Location = new System.Drawing.Point(160, 140);
            this.txt_email.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(578, 36);
            this.txt_email.TabIndex = 6;
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.White;
            this.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_senha.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_senha.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.Color.Black;
            this.txt_senha.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_senha.Location = new System.Drawing.Point(160, 303);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.SelectedText = "";
            this.txt_senha.Size = new System.Drawing.Size(247, 36);
            this.txt_senha.TabIndex = 8;
            // 
            // txt_data
            // 
            this.txt_data.BaseColor = System.Drawing.Color.White;
            this.txt_data.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_data.CustomFormat = null;
            this.txt_data.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_data.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_data.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.ForeColor = System.Drawing.Color.Black;
            this.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_data.Location = new System.Drawing.Point(263, 217);
            this.txt_data.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_data.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_data.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_data.Name = "txt_data";
            this.txt_data.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_data.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_data.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_data.OnPressedColor = System.Drawing.Color.Black;
            this.txt_data.Size = new System.Drawing.Size(144, 40);
            this.txt_data.TabIndex = 44;
            this.txt_data.Text = "04/06/2023";
            this.txt_data.Value = new System.DateTime(2023, 6, 4, 0, 0, 0, 0);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.AnimationHoverSpeed = 0.07F;
            this.btn_cadastrar.AnimationSpeed = 0.03F;
            this.btn_cadastrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cadastrar.BorderColor = System.Drawing.Color.Black;
            this.btn_cadastrar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_cadastrar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_cadastrar.CheckedForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.CheckedImage = null;
            this.btn_cadastrar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_cadastrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cadastrar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_cadastrar.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Image = null;
            this.btn_cadastrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_cadastrar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cadastrar.Location = new System.Drawing.Point(464, 304);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cadastrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cadastrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.OnHoverImage = null;
            this.btn_cadastrar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cadastrar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_cadastrar.Size = new System.Drawing.Size(126, 45);
            this.btn_cadastrar.TabIndex = 45;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Controls.Add(this.btn_limpar);
            this.gunaGroupBox1.Controls.Add(this.txt_celular);
            this.gunaGroupBox1.Controls.Add(this.txt_senha);
            this.gunaGroupBox1.Controls.Add(this.txt_email);
            this.gunaGroupBox1.Controls.Add(this.txt_data);
            this.gunaGroupBox1.Controls.Add(this.btn_cadastrar);
            this.gunaGroupBox1.Controls.Add(this.txt_nome);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(106, 39);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(757, 388);
            this.gunaGroupBox1.TabIndex = 46;
            this.gunaGroupBox1.Text = "CADASTRE-SE AQUI";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(290, 5);
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
            this.btn_limpar.Location = new System.Drawing.Point(612, 304);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_limpar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_limpar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_limpar.OnHoverImage = null;
            this.btn_limpar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_limpar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_limpar.Size = new System.Drawing.Size(126, 45);
            this.btn_limpar.TabIndex = 46;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_celular
            // 
            this.txt_celular.BackColor = System.Drawing.Color.White;
            this.txt_celular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_celular.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_celular.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celular.ForeColor = System.Drawing.Color.Black;
            this.txt_celular.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_celular.Location = new System.Drawing.Point(531, 221);
            this.txt_celular.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.PasswordChar = '\0';
            this.txt_celular.SelectedText = "";
            this.txt_celular.Size = new System.Drawing.Size(207, 36);
            this.txt_celular.TabIndex = 7;
            // 
            // frm_cadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 483);
            this.Controls.Add(this.gunaGroupBox1);
            this.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_cadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List It";
            this.Load += new System.EventHandler(this.frm_cadastroUsuario_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLineTextBox txt_nome;
        private Guna.UI.WinForms.GunaLineTextBox txt_email;
        private Guna.UI.WinForms.GunaLineTextBox txt_senha;
        private Guna.UI.WinForms.GunaDateTimePicker txt_data;
        private Guna.UI.WinForms.GunaAdvenceButton btn_cadastrar;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLineTextBox txt_celular;
        private Guna.UI.WinForms.GunaAdvenceButton btn_limpar;
    }
}
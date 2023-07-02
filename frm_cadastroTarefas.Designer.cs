
namespace ListIt
{
    partial class frm_cadastroTarefas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastroTarefas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tbp_cadastro = new System.Windows.Forms.TabPage();
            this.valorTrackBar = new Guna.UI.WinForms.GunaLabel();
            this.btn_excluir = new Guna.UI.WinForms.GunaImageButton();
            this.btn_editar = new Guna.UI.WinForms.GunaImageButton();
            this.btn_buscar = new Guna.UI.WinForms.GunaImageButton();
            this.btn_cadastrar = new Guna.UI.WinForms.GunaImageButton();
            this.cmb_situacao = new Guna.UI.WinForms.GunaComboBox();
            this.txt_data = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_prioridade = new Guna.UI.WinForms.GunaMetroTrackBar();
            this.txt_descricao = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_nome = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbp_lista = new System.Windows.Forms.TabPage();
            this.dgv_cadastroTarefas = new Guna.UI.WinForms.GunaDataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_consulta = new Guna.UI.WinForms.GunaLineTextBox();
            this.TabControl.SuspendLayout();
            this.tbp_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbp_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cadastroTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tbp_cadastro);
            this.TabControl.Controls.Add(this.tbp_lista);
            this.TabControl.Location = new System.Drawing.Point(74, 25);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(809, 428);
            this.TabControl.TabIndex = 1;
            // 
            // tbp_cadastro
            // 
            this.tbp_cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbp_cadastro.Controls.Add(this.valorTrackBar);
            this.tbp_cadastro.Controls.Add(this.btn_excluir);
            this.tbp_cadastro.Controls.Add(this.btn_editar);
            this.tbp_cadastro.Controls.Add(this.btn_buscar);
            this.tbp_cadastro.Controls.Add(this.btn_cadastrar);
            this.tbp_cadastro.Controls.Add(this.cmb_situacao);
            this.tbp_cadastro.Controls.Add(this.txt_data);
            this.tbp_cadastro.Controls.Add(this.txt_prioridade);
            this.tbp_cadastro.Controls.Add(this.txt_descricao);
            this.tbp_cadastro.Controls.Add(this.txt_nome);
            this.tbp_cadastro.Controls.Add(this.label5);
            this.tbp_cadastro.Controls.Add(this.label4);
            this.tbp_cadastro.Controls.Add(this.label3);
            this.tbp_cadastro.Controls.Add(this.label2);
            this.tbp_cadastro.Controls.Add(this.label1);
            this.tbp_cadastro.Controls.Add(this.pictureBox1);
            this.tbp_cadastro.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp_cadastro.ForeColor = System.Drawing.Color.Black;
            this.tbp_cadastro.Location = new System.Drawing.Point(4, 22);
            this.tbp_cadastro.Name = "tbp_cadastro";
            this.tbp_cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_cadastro.Size = new System.Drawing.Size(801, 402);
            this.tbp_cadastro.TabIndex = 0;
            this.tbp_cadastro.Text = "CADASTRO";
            this.tbp_cadastro.UseVisualStyleBackColor = true;
            // 
            // valorTrackBar
            // 
            this.valorTrackBar.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.valorTrackBar.Location = new System.Drawing.Point(538, 252);
            this.valorTrackBar.Name = "valorTrackBar";
            this.valorTrackBar.Size = new System.Drawing.Size(81, 26);
            this.valorTrackBar.TabIndex = 49;
            this.valorTrackBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_excluir.Location = new System.Drawing.Point(703, 307);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.OnHoverImage = null;
            this.btn_excluir.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_excluir.Size = new System.Drawing.Size(83, 80);
            this.btn_excluir.TabIndex = 48;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_editar.Location = new System.Drawing.Point(703, 212);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.OnHoverImage = null;
            this.btn_editar.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_editar.Size = new System.Drawing.Size(83, 80);
            this.btn_editar.TabIndex = 47;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_buscar.Location = new System.Drawing.Point(703, 113);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.OnHoverImage = null;
            this.btn_buscar.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_buscar.Size = new System.Drawing.Size(83, 80);
            this.btn_buscar.TabIndex = 46;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_cadastrar.Location = new System.Drawing.Point(703, 18);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.OnHoverImage = null;
            this.btn_cadastrar.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_cadastrar.Size = new System.Drawing.Size(83, 80);
            this.btn_cadastrar.TabIndex = 45;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // cmb_situacao
            // 
            this.cmb_situacao.BackColor = System.Drawing.Color.Transparent;
            this.cmb_situacao.BaseColor = System.Drawing.Color.White;
            this.cmb_situacao.BorderColor = System.Drawing.Color.Silver;
            this.cmb_situacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_situacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_situacao.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_situacao.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_situacao.ForeColor = System.Drawing.Color.Black;
            this.cmb_situacao.FormattingEnabled = true;
            this.cmb_situacao.Items.AddRange(new object[] {
            "--",
            "Pendente",
            "Em andamento",
            "Concluído"});
            this.cmb_situacao.Location = new System.Drawing.Point(199, 320);
            this.cmb_situacao.Name = "cmb_situacao";
            this.cmb_situacao.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmb_situacao.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_situacao.Size = new System.Drawing.Size(419, 30);
            this.cmb_situacao.TabIndex = 44;
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
            this.txt_data.Location = new System.Drawing.Point(199, 177);
            this.txt_data.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_data.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_data.Name = "txt_data";
            this.txt_data.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_data.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_data.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_data.OnPressedColor = System.Drawing.Color.Black;
            this.txt_data.Size = new System.Drawing.Size(419, 30);
            this.txt_data.TabIndex = 43;
            this.txt_data.Text = "04/06/2023";
            this.txt_data.Value = new System.DateTime(2023, 6, 4, 0, 0, 0, 0);
            // 
            // txt_prioridade
            // 
            this.txt_prioridade.Location = new System.Drawing.Point(199, 256);
            this.txt_prioridade.Maximum = 5;
            this.txt_prioridade.Minimum = 1;
            this.txt_prioridade.Name = "txt_prioridade";
            this.txt_prioridade.Size = new System.Drawing.Size(333, 22);
            this.txt_prioridade.TabIndex = 42;
            this.txt_prioridade.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_prioridade.TrackHoverColor = System.Drawing.Color.Gray;
            this.txt_prioridade.TrackIdleColor = System.Drawing.Color.Silver;
            this.txt_prioridade.TrackPressedColor = System.Drawing.Color.Black;
            this.txt_prioridade.Value = 3;
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.Color.White;
            this.txt_descricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_descricao.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_descricao.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_descricao.Location = new System.Drawing.Point(199, 100);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.PasswordChar = '\0';
            this.txt_descricao.SelectedText = "";
            this.txt_descricao.Size = new System.Drawing.Size(419, 53);
            this.txt_descricao.TabIndex = 41;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.White;
            this.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nome.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_nome.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_nome.Location = new System.Drawing.Point(199, 45);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(411, 32);
            this.txt_nome.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Situação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Prioridade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tarefa:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(683, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 406);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // tbp_lista
            // 
            this.tbp_lista.Controls.Add(this.txt_consulta);
            this.tbp_lista.Controls.Add(this.label6);
            this.tbp_lista.Controls.Add(this.dgv_cadastroTarefas);
            this.tbp_lista.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp_lista.Location = new System.Drawing.Point(4, 22);
            this.tbp_lista.Name = "tbp_lista";
            this.tbp_lista.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_lista.Size = new System.Drawing.Size(801, 402);
            this.tbp_lista.TabIndex = 1;
            this.tbp_lista.Text = "LISTA";
            this.tbp_lista.UseVisualStyleBackColor = true;
            // 
            // dgv_cadastroTarefas
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_cadastroTarefas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_cadastroTarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cadastroTarefas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_cadastroTarefas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cadastroTarefas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_cadastroTarefas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cadastroTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_cadastroTarefas.ColumnHeadersHeight = 35;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cadastroTarefas.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_cadastroTarefas.EnableHeadersVisualStyles = false;
            this.dgv_cadastroTarefas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_cadastroTarefas.Location = new System.Drawing.Point(3, 52);
            this.dgv_cadastroTarefas.Name = "dgv_cadastroTarefas";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cadastroTarefas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_cadastroTarefas.RowHeadersVisible = false;
            this.dgv_cadastroTarefas.RowTemplate.Height = 25;
            this.dgv_cadastroTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cadastroTarefas.Size = new System.Drawing.Size(793, 344);
            this.dgv_cadastroTarefas.TabIndex = 1;
            this.dgv_cadastroTarefas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightBlue;
            this.dgv_cadastroTarefas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_cadastroTarefas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_cadastroTarefas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_cadastroTarefas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_cadastroTarefas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_cadastroTarefas.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_cadastroTarefas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_cadastroTarefas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_cadastroTarefas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_cadastroTarefas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_cadastroTarefas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_cadastroTarefas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_cadastroTarefas.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_cadastroTarefas.ThemeStyle.ReadOnly = false;
            this.dgv_cadastroTarefas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_cadastroTarefas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_cadastroTarefas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_cadastroTarefas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_cadastroTarefas.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_cadastroTarefas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_cadastroTarefas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Digite uma tarefa a ser consultada:";
            // 
            // txt_consulta
            // 
            this.txt_consulta.BackColor = System.Drawing.Color.White;
            this.txt_consulta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_consulta.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_consulta.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_consulta.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_consulta.Location = new System.Drawing.Point(342, 14);
            this.txt_consulta.Name = "txt_consulta";
            this.txt_consulta.PasswordChar = '\0';
            this.txt_consulta.SelectedText = "";
            this.txt_consulta.Size = new System.Drawing.Size(453, 32);
            this.txt_consulta.TabIndex = 21;
            this.txt_consulta.TextChanged += new System.EventHandler(this.txt_consulta_TextChanged);
            // 
            // frm_cadastroTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 483);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cadastroTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List It";
            this.Load += new System.EventHandler(this.frm_cadastroTarefas_Load);
            this.TabControl.ResumeLayout(false);
            this.tbp_cadastro.ResumeLayout(false);
            this.tbp_cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbp_lista.ResumeLayout(false);
            this.tbp_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cadastroTarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tbp_cadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tbp_lista;
        private Guna.UI.WinForms.GunaLabel valorTrackBar;
        private Guna.UI.WinForms.GunaImageButton btn_excluir;
        private Guna.UI.WinForms.GunaImageButton btn_editar;
        private Guna.UI.WinForms.GunaImageButton btn_buscar;
        private Guna.UI.WinForms.GunaImageButton btn_cadastrar;
        private Guna.UI.WinForms.GunaComboBox cmb_situacao;
        private Guna.UI.WinForms.GunaDateTimePicker txt_data;
        private Guna.UI.WinForms.GunaMetroTrackBar txt_prioridade;
        private Guna.UI.WinForms.GunaLineTextBox txt_descricao;
        private Guna.UI.WinForms.GunaLineTextBox txt_nome;
        private Guna.UI.WinForms.GunaDataGridView dgv_cadastroTarefas;
        private Guna.UI.WinForms.GunaLineTextBox txt_consulta;
        private System.Windows.Forms.Label label6;
    }
}


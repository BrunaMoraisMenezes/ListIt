using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ListIt
{
    public partial class frm_cadastroUsuario : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        string sqlQuery;

        public frm_cadastroUsuario()
        {
            InitializeComponent();
        }
        private void frm_cadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"server=DESKTOP-MGHGGEJ\MSSQLSERVER01;Database=LISTIT;trusted_connection=yes;");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "INSERT INTO TB_USUARIO(NOME, CELULAR, EMAIL, DATA_NASCIMENTO, SENHA) " +
                    "VALUES(@NOME, @CELULAR, @EMAIL, @DATA_NASCIMENTO, @SENHA)";
                comando = new SqlCommand(sqlQuery, conexao);
                comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
                comando.Parameters.AddWithValue("@CELULAR", txt_celular.Text);
                comando.Parameters.AddWithValue("@EMAIL", txt_email.Text);
                comando.Parameters.AddWithValue("@DATA_NASCIMENTO", txt_data.Value.ToString());
                comando.Parameters.AddWithValue("@SENHA", txt_senha.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                frm_login login = new frm_login();
                login.Show();
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_nome.Clear();
                txt_celular.Clear();
                txt_email.Clear();
                txt_data.Text = DateTime.Now.ToString();
                txt_senha.Clear();
                txt_nome.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

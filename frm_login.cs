using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ListIt
{
    public partial class frm_login : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        string sqlQuery;

        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
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

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                sqlQuery = "SELECT COUNT(*) FROM TB_USUARIO WHERE NOME = @NOME AND SENHA = @SENHA";
                comando = new SqlCommand(sqlQuery, conexao);
                comando.Parameters.AddWithValue("@NOME", txt_usuario.Text);
                comando.Parameters.AddWithValue("@SENHA", txt_senha.Text);

                int contador = (int)comando.ExecuteScalar();

                if (contador > 0)
                {
                    this.Hide();
                    frm_cadastroTarefas frm_cadastroTarefas = new frm_cadastroTarefas();
                    frm_cadastroTarefas.Show();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos");
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void lbl_chamaForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_cadastroUsuario frm_cadastroUsuario = new frm_cadastroUsuario();
            frm_cadastroUsuario.Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_usuario.Clear();
                txt_senha.Clear();
                txt_usuario.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

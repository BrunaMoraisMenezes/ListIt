using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ListIt
{
    public partial class frm_cadastroTarefas : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        string sqlQuery;

        public frm_cadastroTarefas()
        {
            InitializeComponent();
        }

        private void frm_cadastroTarefas_Load(object sender, EventArgs e)
        {
            try
            {
                txt_prioridade.Scroll += TrackBar_Rolamento;
                txt_prioridade.ValueChanged += TrackBar_Atualizacao;

                conexao = new SqlConnection(@"server=DESKTOP-MGHGGEJ\MSSQLSERVER01;Database=LISTIT;trusted_connection=yes;");
                sqlQuery = "SELECT * FROM TB_TAREFAS ORDER BY PRIORIDADE ASC";
                SqlDataAdapter data = new SqlDataAdapter(sqlQuery, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_cadastroTarefas.DataSource = tabela.Tables[0];
                dgv_cadastroTarefas.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TrackBar_Rolamento(object sender, EventArgs e)
        {
            // Atualizar o valor exibido quando o TrackBar é rolado
            int valor = txt_prioridade.Value;
            valorTrackBar.Text = valor.ToString();
        }

        private void TrackBar_Atualizacao(object sender, EventArgs e)
        {
            // Atualizar o valor exibido quando o valor do TrackBar é alterado
            int valor = txt_prioridade.Value;
            valorTrackBar.Text = valor.ToString();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "INSERT INTO TB_TAREFAS(NOME, DESCRICAO, DATA_TAREFA, PRIORIDADE, SITUACAO) VALUES(@NOME, @DESCRICAO, @DATA_TAREFA, @PRIORIDADE, @SITUACAO)";
                comando = new SqlCommand(sqlQuery, conexao);
                comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
                comando.Parameters.AddWithValue("@DESCRICAO", txt_descricao.Text);
                comando.Parameters.AddWithValue("@DATA_TAREFA", txt_data.Value.ToString());
                comando.Parameters.AddWithValue("@PRIORIDADE", txt_prioridade.Value.ToString());
                comando.Parameters.AddWithValue("@SITUACAO", cmb_situacao.SelectedItem);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Tarefa cadastrada com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlQuery = "SELECT * FROM TB_TAREFAS ORDER BY PRIORIDADE ASC";
                SqlDataAdapter data = new SqlDataAdapter(sqlQuery, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_cadastroTarefas.DataSource = tabela.Tables[0];
                dgv_cadastroTarefas.Refresh();
                txt_nome.Clear();
                txt_descricao.Clear();
                txt_data.Text = DateTime.Now.ToString();
                txt_prioridade.ToString();
                valorTrackBar.Text = "3";
                cmb_situacao.Text = "--";
                txt_nome.Focus();
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                sqlQuery = "SELECT * FROM TB_TAREFAS WHERE NOME = '" + txt_nome.Text + "'";
                SqlDataAdapter data = new SqlDataAdapter(sqlQuery, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                txt_nome.Text = tabela.Tables[0].Rows[0]["NOME"].ToString();
                txt_descricao.Text = tabela.Tables[0].Rows[0]["DESCRICAO"].ToString();
                txt_data.Text = tabela.Tables[0].Rows[0]["DATA_TAREFA"].ToString();
                txt_prioridade.Value = Convert.ToInt32(tabela.Tables[0].Rows[0]["PRIORIDADE"].ToString());
                valorTrackBar.Text = tabela.Tables[0].Rows[0]["PRIORIDADE"].ToString();
                cmb_situacao.Text = tabela.Tables[0].Rows[0]["SITUACAO"].ToString();
            }
            catch
            {
                MessageBox.Show("Tarefa não localizada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                sqlQuery = "UPDATE TB_TAREFAS SET NOME = @NOME, DESCRICAO = @DESCRICAO, DATA_TAREFA = @DATA_TAREFA, PRIORIDADE = @PRIORIDADE," +
                    "SITUACAO = @SITUACAO WHERE NOME = @NOME";
                comando = new SqlCommand(sqlQuery, conexao);
                comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
                comando.Parameters.AddWithValue("@DESCRICAO", txt_descricao.Text);
                comando.Parameters.AddWithValue("@DATA_TAREFA", txt_data.Value.ToString());
                comando.Parameters.AddWithValue("@PRIORIDADE", txt_prioridade.Value.ToString());
                comando.Parameters.AddWithValue("@SITUACAO", cmb_situacao.SelectedItem);
                comando.CommandType = CommandType.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Informações atualizadas com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlQuery = "SELECT * FROM TB_TAREFAS ORDER BY PRIORIDADE ASC";
                SqlDataAdapter data = new SqlDataAdapter(sqlQuery, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_cadastroTarefas.DataSource = tabela.Tables[0];
                dgv_cadastroTarefas.Refresh();
                txt_nome.Clear();
                txt_descricao.Clear();
                txt_data.Text = DateTime.Now.ToString();
                txt_prioridade.ToString();
                valorTrackBar.Text = "3";
                cmb_situacao.Text = "--";
                txt_nome.Focus();
            }
            catch
            {
                MessageBox.Show("Erro ao atualizar as informações", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conexao.Close();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                sqlQuery = "DELETE FROM TB_TAREFAS WHERE NOME = @NOME";
                comando = new SqlCommand(sqlQuery, conexao);
                comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados excluídos com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlQuery = "SELECT * FROM TB_TAREFAS ORDER BY PRIORIDADE ASC";
                SqlDataAdapter data = new SqlDataAdapter(sqlQuery, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_cadastroTarefas.DataSource = tabela.Tables[0];
                dgv_cadastroTarefas.Refresh();
                txt_nome.Clear();
                txt_descricao.Clear();
                txt_data.Text = DateTime.Now.ToString();
                txt_prioridade.Value = Convert.ToInt32(3);
                valorTrackBar.Text = "3";
                cmb_situacao.Text = "--";
                txt_nome.Focus();
            }
            catch
            {
                MessageBox.Show("Erro ao excluir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txt_consulta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "SELECT * FROM TB_TAREFAS WHERE NOME LIKE '" + txt_consulta.Text + "%'";
                SqlDataAdapter data = new SqlDataAdapter(sqlQuery, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_cadastroTarefas.DataSource = tabela.Tables[0];
                dgv_cadastroTarefas.Refresh();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

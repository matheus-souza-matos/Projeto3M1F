using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMISSAO_NOTAS
{
    public partial class NovoUsuario : Form
    {
        MySqlConnection Conexao;

        public int IdUsuario = 1;
        public string data_source = "datasource=Localhost;username=root;password=;database=Notas_Fiscais";
        public NovoUsuario()
        {
            InitializeComponent();
            CarregarProximoIdDoBanco();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpar()
        {
            txtNovoUsuario.Clear();
            txtSenhaNovoUsuario.Clear();
        }

        private void CarregarProximoIdDoBanco()
        {
            Conexao = new MySqlConnection(data_source);
            try
            {
                Conexao.Open();
                string selectIdUsuBanco = "SELECT MAX(id_usuario) FROM login";
                MySqlCommand selectbanc = new MySqlCommand(selectIdUsuBanco, Conexao);
                object resultadoMax = selectbanc.ExecuteScalar();

                if (resultadoMax != DBNull.Value && resultadoMax != null)
                {
                    IdUsuario = Convert.ToInt32(resultadoMax) + 1;
                }
                else
                {
                    IdUsuario = 1;
                }

            }
            catch (MySqlException ex)
            {
                Erro($"Erro ao carregar o próximo ID: {ex.Message}");
            }
            finally
            {
                Conexao.Close();
            }

        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {
            txtIdUsuarioCadastrado.Text = IdUsuario.ToString();
            txtIdUsuarioCadastrado.Enabled = false;
        }

        private void btnCadastrarNovoUsuario_Click(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
            MySqlCommand prodcmd = new MySqlCommand();
            prodcmd.Connection = Conexao;


            if (string.IsNullOrEmpty(txtNovoUsuario.Text) || string.IsNullOrEmpty(txtSenhaNovoUsuario.Text))
            {
                Erro("Não pode conter campos vazios!");
                return;
            }
            else
            {
                prodcmd.Parameters.Clear();
                prodcmd.CommandText =
                    "INSERT INTO login " +
                    "(user, senha) " +
                    "VALUES " +
                    "(@user, @senha)";

                prodcmd.Parameters.AddWithValue("@user", txtNovoUsuario.Text);
                prodcmd.Parameters.AddWithValue("@senha", txtSenhaNovoUsuario.Text);

                prodcmd.ExecuteNonQuery();
                Sucesso("Usuário Cadastrado com sucesso!");
                IdUsuario++; 
                txtIdUsuarioCadastrado.Text = IdUsuario.ToString(); 
                Limpar();

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);
            try
            {
                Conexao.Open();
                string contarUsuario = "SELECT COUNT(*) FROM login";
                MySqlCommand verificarCmd = new MySqlCommand(contarUsuario, Conexao);
                int verificarQuantUsu = Convert.ToInt32(verificarCmd.ExecuteScalar());

                if (verificarQuantUsu == 1)
                {
                    MessageBox.Show("É necessário realizar o cadastro de um usuário para poder retornar a tela de login.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    this.Close();
                }
            }
            catch (MySqlException ex)
            {
                Erro($"Erro ao vericar se há existência de usuários: {ex.Message}");
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}

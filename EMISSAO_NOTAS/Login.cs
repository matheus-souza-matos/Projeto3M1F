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
    public partial class Login : Form
    {
        MySqlConnection Conexao;

        public string data_source = "datasource=Localhost;username=root;password=;database=Notas_Fiscais";
        public Login()
        {
            InitializeComponent();
            Usuario();
        }

        private void limpar_formulario()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void Usuario()
        {
            Conexao = new MySqlConnection(data_source);

            try
            {
                Conexao.Open();
                string verificarAdmin = "SELECT COUNT(*) FROM login WHERE id_usuario";
                MySqlCommand verificarCmd = new MySqlCommand(verificarAdmin, Conexao);
                int count = Convert.ToInt32(verificarCmd.ExecuteScalar());


                if (count == 0)
                {
                    string inserirUsuario = "INSERT INTO login (user, senha) VALUES ('admin', 'admin')";
                    MySqlCommand insertcmd = new MySqlCommand(inserirUsuario, Conexao);
                    insertcmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário de acesso criado com sucesso!\nCrie seu usuário para acessos futuros", "Primeiro Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtUsuario.Text = "admin";
                    txtUsuario.ForeColor = Color.Black; // A justar a cor do texto
                    txtSenha.Text = "admin";
                    txtSenha.ForeColor = Color.Black; // Ajustar a cor do texto
                    txtSenha.PasswordChar = '*'; //Mostrar a senha como asteriscos

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao criar usuário de acesso: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuarioDigitado = txtUsuario.Text.Trim().ToUpper();
            string senhaDigitada = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(usuarioDigitado))
            {
                MessageBox.Show("Campo 'Usuário' é preenchimento obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(usuarioDigitado))
            {
                MessageBox.Show("Campo 'Senha' é de preenchimento obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            Conexao = new MySqlConnection(data_source);

            try
            {
                Conexao.Open();

                string selectBanco = "SELECT id_usuario FROM login WHERE user = @usuario AND senha = @senha";
                MySqlCommand cmdTipoU = new MySqlCommand(selectBanco, Conexao);
                cmdTipoU.Parameters.AddWithValue("@usuario", usuarioDigitado);
                cmdTipoU.Parameters.AddWithValue("@senha", senhaDigitada);

                object resultado = cmdTipoU.ExecuteScalar();

                if (resultado != null && int.TryParse(resultado.ToString(), out int usuarioLogado))
                {
                    if (usuarioLogado == 1)
                    {
                        limpar_formulario();
                        NovoUsuario novousuarioForm = new NovoUsuario();
                        novousuarioForm.ShowDialog();
                    }
                    else
                    {
                        limpar_formulario();
                        Menu menuForm = new Menu();
                        menuForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    limpar_formulario();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao conectar ou consultar o banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}

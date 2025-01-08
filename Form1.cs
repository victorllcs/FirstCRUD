using MySql.Data.MySqlClient;

namespace Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtNome.Text.Equals("") && txtCPF.Text.Equals("") && txtEmail.Text.Equals("") && txtEndereco.Text.Equals("")))
                {
                    CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
                    cadastroFuncionarios.Name = txtNome.Text;
                    cadastroFuncionarios.Email = txtEmail.Text;
                    cadastroFuncionarios.CPF = txtCPF.Text;
                    cadastroFuncionarios.Adress = txtEndereco.Text;

                    if (cadastroFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcion�rio {cadastroFuncionarios.Name} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCPF.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel cadastrar funcion�rio.");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente.");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtCPF.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcion�rio" + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals(""))
                {
                    CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
                    cadastroFuncionarios.CPF = txtCPF.Text;

                    MySqlDataReader reader = cadastroFuncionarios.localizarFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblID.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Funcion�rio n�o encontrado");
                            txtNome.Clear();
                            txtEmail.Clear();
                            txtCPF.Clear();
                            txtEndereco.Clear();
                            txtCPF.Focus();
                            lblID.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcion�rio n�o encontrado!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtCPF.Focus();
                        lblID.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o CPF para realizar a pesquisa.");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    txtCPF.Focus();
                    lblID.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar funcion�rio:" + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtNome.Focus();
            lblID.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
                    cadastroFuncionarios.Id = int.Parse(lblID.Text);
                    cadastroFuncionarios.Email = txtEmail.Text;
                    cadastroFuncionarios.Adress = txtEndereco.Text;

                    if (cadastroFuncionarios.atualizarFuncionario())
                    {
                        MessageBox.Show("Os dados do funcion�rio foram atualizados com sucesso");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        lblID.Text = "";
                        txtCPF.Focus();
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel atualizar as informa��es do funcion�rio");
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o funcion�rio que deseja atualizar as informa��es");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    lblID.Text = "";
                    txtCPF.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do funcion�rio" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCPF.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
                    cadastroFuncionarios.Id = int.Parse(lblID.Text);
                    if (cadastroFuncionarios.deletarFuncionario())
                    {
                        MessageBox.Show("O funcion�rio foi exclu�do com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        lblID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel excluir o funcion�rio");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        lblID.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar o funcion�rio que deseja excluir");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir funcion�rio: " + ex.Message);
            }
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

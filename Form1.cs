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
                        MessageBox.Show($"O funcionário {cadastroFuncionarios.Name} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtCPF.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar funcionário.");
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
                MessageBox.Show("Erro ao cadastrar funcionário" + ex.Message);
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
                            MessageBox.Show("Funcionário não encontrado");
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
                        MessageBox.Show("Funcionário não encontrado!");
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
                MessageBox.Show("Erro ao encontrar funcionário:" + ex.Message);
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
                        MessageBox.Show("Os dados do funcionário foram atualizados com sucesso");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        lblID.Text = "";
                        txtCPF.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações do funcionário");
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o funcionário que deseja atualizar as informações");
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
                MessageBox.Show("Erro ao atualizar dados do funcionário" + ex.Message);
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
                        MessageBox.Show("O funcionário foi excluído com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        lblID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o funcionário");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        lblID.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar o funcionário que deseja excluir");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir funcionário: " + ex.Message);
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

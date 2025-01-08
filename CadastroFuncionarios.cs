using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class CadastroFuncionarios
    {
        private int id;
        private string name;
        private string email;
        private string cpf;
        private string adress;

        public int Id
        {
           get { return id; }
           set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        //Método para cadastrar funcionário ao banco de dados
        public bool cadastrarFuncionarios()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor); //Conecta no banco de dados
                MysqlConexaoBanco.Open();//Abre a conexão com o banco de dados

                string insert = $"insert into funcionarios (nome,email,cpf,endereco) values ('{Name}','{Email}','{CPF}','{Adress}')";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                /*Mensagens de erro do banco de dados quando não for possível cadastrar usuários ou funcionários no banco
                 Erro ligado ao banco de dados*/
                MessageBox.Show("Erro no banco de dados - Método cadastrarFuncionario:" + ex.Message);
                return false;
            }
        }

        public MySqlDataReader localizarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select id,nome,email,cpf, endereco from funcionarios where cpf = '{cpf}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados - Método localizarFuncionario:" + ex.Message);
                return null;
            }
        }
        public bool atualizarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"update funcionarios set email = '{Email}', endereco = '{Adress}' where id = '{id}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Banco de Dados - método atualizarFuncionario" + ex.Message);
                return false;
            }
        }
        public bool deletarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"delete from funcionarios where id='{id}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro banco de dados - Método deletarFuncionário:" + ex.Message);
                return false;
            }
        }
    }
}

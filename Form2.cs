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

namespace Funcionario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }


        private void lblBanco_Click(object sender, EventArgs e)
        {
            
        }
        /*static bool escreverFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string query = "select from funcionarios id,nome,cpf,numero,endereco";
                MySqlCommand comandosql = new MySqlCommand(query, MysqlConexaoBanco);
                MySqlDataReader reader = comandosql.ExecuteReader();

                StringBuilder sb = new StringBuilder();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        sb.Append(reader.GetName(i) + ":" + reader[i].ToString() + "");
                    }
                    sb.AppendLine();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro banco de dados - Método escreverFuncionários: " + ex.Message);
                return false;
            }
        }*/
    }
}

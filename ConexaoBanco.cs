using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{

    /*Sempre lembrar de baixar os comandos SQL para o programa.
      Botão direito, gerenciar pacotes do nuget e instalar o mysql.data*/
    static class ConexaoBanco
    {            
        //4 variáveis declaradas passando as informações do banco de dados
        private const string servidor = "localHost";
        private const string bancoDados = "dbFuncionarios";
        private const string usuario = "root";
        private const string senha = "JesusIsKing@01";

        //declarando uma variável para fazer a conexão do banco de dados
        static public string bancoServidor = $"server={servidor};user id={usuario};database={bancoDados};password={senha}";
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin___GameLogged
{
    internal class ConexaoBanco
    {

        string dadosConexao = "server=localhost;port=3306;database=gamelogged;user=root;password=teste123";
        //string com acesso ao banco de dados

        public MySqlConnection conectar()
        {
            return new MySqlConnection(dadosConexao);
        }
    }
}

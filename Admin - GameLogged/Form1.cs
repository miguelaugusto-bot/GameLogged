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

namespace Admin___GameLogged
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void teste_Click(object sender, EventArgs e)
        {
            // Cria uma instância da classe que você acabou de criar
            ConexaoBanco bd = new ConexaoBanco();
            MySqlConnection conexao = bd.conectar();

            try
            {
                conexao.Open();
                MessageBox.Show("Conectado usando o arquivo separado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

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
    public partial class Painel_Dash : Form
    {
        public Painel_Dash()
        {
            InitializeComponent();
        }

        private void Painel_Dash_Load(object sender, EventArgs e)
        {

        }

        private void bt_usuario_Click(object sender, EventArgs e)
        {
            ConexaoBanco bd = new ConexaoBanco();
            MySqlConnection conexao = bd.conectar();

            try
            {
                conexao.Open();

                // 1. O comando SQL que você quer executar
                string sql = "SELECT * FROM gamelogged.usuario;";

                // 2. O adaptador que vai "traduzir" os dados do MySQL para o C#
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

                // 3. Uma tabela temporária na memória do computador para guardar os dados
                DataTable tabelaDados = new DataTable();

                // 4. Preenche essa tabela com os dados do banco
                adapter.Fill(tabelaDados);

                // 5. Joga os dados dentro do componente visual que você arrastou
                dataGridView1.DataSource = tabelaDados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

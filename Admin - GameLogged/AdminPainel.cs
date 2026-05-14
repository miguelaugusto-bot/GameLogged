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
    public partial class AdminPainel : Form
    {
        public AdminPainel()
        {
            InitializeComponent();
        }

        private void Painel_Dash_Load(object sender, EventArgs e)
        {

        }

        private void carregar_Dados()
        {

        }

        private void bt_usuario_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear(); //limpar os botões
            ConexaoBanco bd = new ConexaoBanco();
            MySqlConnection conexao = bd.conectar();

            try
            {
                conexao.Open();

                //Comando para selecionar toda a tabela de usuario
                string sql = "SELECT * FROM gamelogged.usuario;";

                //Tradudir o conteudo que esta no sql para o c#
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

                // Tabela temporaria na memoria como uam objeto
                DataTable tabelaDados = new DataTable();

                //preencher os valores
                adapter.Fill(tabelaDados);

                //Joga os dados dentro do componente visual que você arrastou
                dataGridView1.DataSource = tabelaDados;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["dt_nasc"].HeaderText = "Data de Nascimento"; //Renomear a coluna de nascimento para ficar mais dinamico

                // Coluna de Editar
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true; // Faz o texto "Editar" aparecer no botão
                dataGridView1.Columns.Add(btnEditar);

                // Coluna de Excluir
                DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
                btnExcluir.Name = "Excluir";
                btnExcluir.HeaderText = "";
                btnExcluir.Text = "Excluir";
                btnExcluir.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnExcluir);


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

        private void bt_solicitações_Click(object sender, EventArgs e)
        {

        }

        private void bt_dashboard_Click(object sender, EventArgs e)
        {

        }
    }
}

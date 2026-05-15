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
            carregar_Dados();
        }

        private void Painel_Dash_Load(object sender, EventArgs e)
        {

        }

        public void editar_dados()
        {

        }

        public void excluir_dados(string idUsuario)
        {
            // 1. Usamos a classe que você já criou para pegar a conexão
            ConexaoBanco bd = new ConexaoBanco();

            // O 'using' garante que a conexão abra e feche sem você se preocupar
            using (MySqlConnection conexao = bd.conectar())
            {
                try
                {
                    conexao.Open();

                    // 2. Preparamos o comando de exclusão
                    string sql = "DELETE FROM gamelogged.usuario WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", idUsuario);

                    // 3. Executamos o comando
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Usuário removido com sucesso!");

                        // --- O PULO DO GATO ---
                        // Chamamos o método carregar_Dados() aqui. 
                        // Ele vai limpar o grid e buscar os dados atualizados do banco.
                        carregar_Dados();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        public void inserir_dados()
        {

        }

        public void procurar_dados()
        {

        }

        public void acesso_banco()
        {

        }

        public void carregar_Dados()
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

                // Coluna de Excluir (irei explicar com detalhes)
                DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn(); //Instancia um botão 
                btnExcluir.Name = "Excluir"; //Nome da entidade
                btnExcluir.HeaderText = ""; //O conteudo acima do texto (mais para icone)
                btnExcluir.Text = "Excluir"; //Texto que ira aparecer
                btnExcluir.UseColumnTextForButtonValue = true; //Botão ativado para função
                dataGridView1.Columns.Add(btnExcluir); //Adicionar no datagrid


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora se clicar no cabeçalho ou fora das linhas
            if (e.RowIndex < 0) return;

            // 1. PEGA O ID DA LINHA CLICADA (Fundamental para ambos os casos)
            // Certifique-se que o nome "id" é o nome da coluna no seu banco/DataTable
            string idSelecionado = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

            // 2. VERIFICA SE CLICOU NO EDITAR
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                // Aqui você pega os outros dados se precisar passar para outro Form
                string nome = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();

                // Chama seu método (ajuste os parâmetros se necessário)
                // editar_dados(idSelecionado, nome); 
                MessageBox.Show("Abrindo edição do usuário: " + nome);
            }

            // 3. VERIFICA SE CLICOU NO EXCLUIR
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Excluir")
            {
                DialogResult confirmacao = MessageBox.Show(
                    "Tem certeza que deseja excluir este registro?",
                    "Atenção!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacao == DialogResult.Yes)
                {
                    // Chama seu método de excluir passando o ID
                    excluir_dados(idSelecionado);

                    // O excluir_dados deve chamar o carregar_Dados() no final 
                    // para a linha sumir da tela na hora!
                }
            }
        }

        private void bt_usuario_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_solicitações_Click(object sender, EventArgs e)
        {

        }

        private void bt_dashboard_Click(object sender, EventArgs e)
        {

        }
    }
}

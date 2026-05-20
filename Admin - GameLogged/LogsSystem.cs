using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Admin___GameLogged
{
    public partial class LogsSystem : Form
    {
        string path = @"D:\Repositorios\Uninove\Projetos\GameLogged\Admin - GameLogged\Logs.txt";
        public LogsSystem()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLog.Text))
            {
                MessageBox.Show("O campo de log está vazio. Por favor, insira um log para salvar.");
                return;
            }
            try
            {
                string diretorioPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(diretorioPath))
                {
                    Directory.CreateDirectory(diretorioPath);
                }

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    string logFormato = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {txtLog.Text}";
                    sw.WriteLine(logFormato);
                }
                MessageBox.Show("Log salvo com sucesso!");
                txtLog.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o log: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

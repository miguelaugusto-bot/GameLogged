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
            Painel_Dash novoForm = new Painel_Dash();
            novoForm.Tag = this;
            novoForm.Show();
            this.Hide();
        }
    }
}

namespace Admin___GameLogged
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.teste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teste
            // 
            this.teste.Location = new System.Drawing.Point(170, 155);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(139, 23);
            this.teste.TabIndex = 0;
            this.teste.Text = "Teste de Banco";
            this.teste.UseMnemonic = false;
            this.teste.UseVisualStyleBackColor = true;
            this.teste.Click += new System.EventHandler(this.teste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.teste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teste;
    }
}


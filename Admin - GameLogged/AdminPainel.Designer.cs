namespace Admin___GameLogged
{
    partial class AdminPainel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_dashboard = new System.Windows.Forms.Button();
            this.bt_usuario = new System.Windows.Forms.Button();
            this.bt_solicitações = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_dashboard
            // 
            this.bt_dashboard.Location = new System.Drawing.Point(12, 124);
            this.bt_dashboard.Name = "bt_dashboard";
            this.bt_dashboard.Size = new System.Drawing.Size(216, 34);
            this.bt_dashboard.TabIndex = 0;
            this.bt_dashboard.Text = "Dashboard";
            this.bt_dashboard.UseVisualStyleBackColor = true;
            this.bt_dashboard.Click += new System.EventHandler(this.bt_dashboard_Click);
            // 
            // bt_usuario
            // 
            this.bt_usuario.Location = new System.Drawing.Point(12, 164);
            this.bt_usuario.Name = "bt_usuario";
            this.bt_usuario.Size = new System.Drawing.Size(216, 37);
            this.bt_usuario.TabIndex = 1;
            this.bt_usuario.Text = "Usuários";
            this.bt_usuario.UseVisualStyleBackColor = true;
            this.bt_usuario.Click += new System.EventHandler(this.bt_usuario_Click);
            // 
            // bt_solicitações
            // 
            this.bt_solicitações.Location = new System.Drawing.Point(12, 207);
            this.bt_solicitações.Name = "bt_solicitações";
            this.bt_solicitações.Size = new System.Drawing.Size(216, 38);
            this.bt_solicitações.TabIndex = 2;
            this.bt_solicitações.Text = "Solicitações";
            this.bt_solicitações.UseVisualStyleBackColor = true;
            this.bt_solicitações.Click += new System.EventHandler(this.bt_solicitações_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(255, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(874, 532);
            this.dataGridView1.TabIndex = 3;
            // 
            // AdminPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 667);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_solicitações);
            this.Controls.Add(this.bt_usuario);
            this.Controls.Add(this.bt_dashboard);
            this.Name = "AdminPainel";
            this.Text = "Painel - Dash";
            this.Load += new System.EventHandler(this.Painel_Dash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_dashboard;
        private System.Windows.Forms.Button bt_usuario;
        private System.Windows.Forms.Button bt_solicitações;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
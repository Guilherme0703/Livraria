namespace WindowsFormsApplication1
{
    partial class frmMenu
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.Consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.sair_Estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastros,
            this.Consultas,
            this.sair_Estoque});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(976, 24);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // Cadastros
            // 
            this.Cadastros.Name = "Cadastros";
            this.Cadastros.Size = new System.Drawing.Size(66, 20);
            this.Cadastros.Text = "&Cadastro";
            this.Cadastros.Click += new System.EventHandler(this.Cadastros_Click);
            // 
            // Consultas
            // 
            this.Consultas.Name = "Consultas";
            this.Consultas.Size = new System.Drawing.Size(66, 20);
            this.Consultas.Text = "C&onsulta";
            this.Consultas.Click += new System.EventHandler(this.Consultas_Click);
            // 
            // sair_Estoque
            // 
            this.sair_Estoque.Name = "sair_Estoque";
            this.sair_Estoque.Size = new System.Drawing.Size(38, 20);
            this.sair_Estoque.Text = "&Sair";
            this.sair_Estoque.Click += new System.EventHandler(this.sair_Estoque_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 608);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Cadastros;
        private System.Windows.Forms.ToolStripMenuItem Consultas;
        private System.Windows.Forms.ToolStripMenuItem sair_Estoque;
    }
}


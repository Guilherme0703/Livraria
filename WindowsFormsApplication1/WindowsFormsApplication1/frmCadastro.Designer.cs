namespace WindowsFormsApplication1
{
    partial class frmCadastro
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnremover = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnremover);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtAno);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtPag);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtEstoque);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtAutora);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtEditora);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtLivro);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(818, 168);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Informação";
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(419, 140);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(75, 23);
            this.btnremover.TabIndex = 13;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ano:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(542, 108);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(94, 21);
            this.txtAno.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(338, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Páginas:";
            // 
            // txtPag
            // 
            this.txtPag.Location = new System.Drawing.Point(383, 108);
            this.txtPag.Name = "txtPag";
            this.txtPag.Size = new System.Drawing.Size(94, 21);
            this.txtPag.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(201, 108);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(94, 21);
            this.txtEstoque.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor:";
            // 
            // txtAutora
            // 
            this.txtAutora.Location = new System.Drawing.Point(49, 81);
            this.txtAutora.Name = "txtAutora";
            this.txtAutora.Size = new System.Drawing.Size(760, 21);
            this.txtAutora.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Editora:";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(49, 54);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(760, 21);
            this.txtEditora.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Livro:";
            // 
            // txtLivro
            // 
            this.txtLivro.Location = new System.Drawing.Point(49, 27);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(760, 21);
            this.txtLivro.TabIndex = 0;
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AllowUserToDeleteRows = false;
            this.dgvGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Location = new System.Drawing.Point(2, 177);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersVisible = false;
            this.dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrid.Size = new System.Drawing.Size(818, 267);
            this.dgvGrid.TabIndex = 1;
            this.dgvGrid.DoubleClick += new System.EventHandler(this.dgvGrid_DoubleClick);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 445);
            this.Controls.Add(this.dgvGrid);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnremover;
    }
}
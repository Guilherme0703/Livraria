using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCadastro : Form
    {
        #region Variaveis Globais

        int intCod = 0;

        #endregion

        #region Metodos
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CONTROL.Validacao valida = new CONTROL.Validacao();

            if (intCod == 0)
            {
                MODEL.Table Livro = new MODEL.Table();
                Livro.Livro = txtLivro.Text;
                Livro.Autor = txtAutora.Text;
                Livro.Editora = txtEditora.Text;
               
                string validou = valida.validaCampos(Livro, txtAno.Text, txtEstoque.Text, txtPag.Text);
                if (validou.Equals(string.Empty))
                {
                    Livro.Ano = int.Parse(txtAno.Text);
                    Livro.Estoque = int.Parse(txtEstoque.Text);
                    Livro.Paginas = int.Parse(txtPag.Text);
                    MODEL.LivrariaEntities3 context = new MODEL.LivrariaEntities3();
                    context.Tables.Add(Livro);
                    context.SaveChanges();
                    lerEstoque();
                }
                else
                {
                    MessageBox.Show(validou);
                    return;
                }
            }
            else
            {
                MODEL.LivrariaEntities3 context = new MODEL.LivrariaEntities3();
                int del = int.Parse(dgvGrid.SelectedRows[0].Cells[0].Value.ToString());
                MODEL.Table Livro = new MODEL.Table { Id = del };
                Livro.Livro = txtLivro.Text;
                Livro.Autor = txtAutora.Text;
                Livro.Editora = txtEditora.Text;
                
                string validou = valida.validaCampos(Livro, txtAno.Text, txtEstoque.Text,txtPag.Text);
                if (validou.Equals(string.Empty))
                {
                    Livro.Ano = int.Parse(txtAno.Text);
                    Livro.Estoque = int.Parse(txtEstoque.Text);
                    Livro.Paginas = int.Parse(txtPag.Text);
                    context.Entry(Livro).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    lerEstoque();
                }
                else
                {
                    MessageBox.Show(validou);
                    return;
                }

            }
            txtAno.Text = txtAutora.Text = txtEditora.Text = txtEstoque.Text = txtLivro.Text = txtPag.Text = string.Empty;
            intCod = 0;
        }

        private void lerEstoque()
        {
            try
            {
                MODEL.LivrariaEntities3 context = new MODEL.LivrariaEntities3();

                var query = from p in context.Tables select p;
                var orderquery = query.OrderBy(f => f.Livro);
                query.OrderByDescending(x => x.Livro);
                dgvGrid.DataSource = orderquery.ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao buscar as informações.");
            }

        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            try
            {
                MODEL.LivrariaEntities3 context = new MODEL.LivrariaEntities3();
                int del = int.Parse(dgvGrid.SelectedRows[0].Cells[0].Value.ToString());
                MODEL.Table Livro = new MODEL.Table { Id = del };
                context.Entry(Livro).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

                lerEstoque();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao remover as informações.");
            }
        }

        private void dgvGrid_DoubleClick(object sender, EventArgs e)
        {
            if(dgvGrid.SelectedRows.Count > 0)
            {
                txtLivro.Text = dgvGrid.SelectedRows[0].Cells[1].Value.ToString();
                txtAutora.Text = dgvGrid.SelectedRows[0].Cells[2].Value.ToString();
                txtEditora.Text =  dgvGrid.SelectedRows[0].Cells[3].Value.ToString();
                txtAno.Text = dgvGrid.SelectedRows[0].Cells[4].Value.ToString();
                txtPag.Text =   dgvGrid.SelectedRows[0].Cells[5].Value.ToString();
                txtEstoque.Text =  dgvGrid.SelectedRows[0].Cells[6].Value.ToString();
                intCod = int.Parse(dgvGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        #endregion
    }
}

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
    public partial class frmConsulta : Form
    {
        #region Variaveis Globais

        DataSet ds = new DataSet();

        #endregion

        #region Metodos do Form
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            MODEL.LivrariaEntities3 context = new MODEL.LivrariaEntities3();

            var query = from p in context.Tables select p;
            var orderquery = query.OrderBy(f => f.Livro);
            query.OrderByDescending(x => x.Livro);
            dgvGrid.DataSource = orderquery.ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dgvGrid.DataSource = null;
            carregaGrid();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveAs = new SaveFileDialog();
            saveAs.Filter = "Arquivo XLS | *.xls ";
            saveAs.DefaultExt = "xls";
            saveAs.ShowDialog();

            dgvGrid.ExportToXls(saveAs.FileName);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveAs = new SaveFileDialog();
            saveAs.Filter = "Arquivo HTML | *.html ";
            saveAs.DefaultExt = "html";
            saveAs.ShowDialog();

            dgvGrid.ExportToHtml(saveAs.FileName);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveAs = new SaveFileDialog();
            saveAs.Filter = "Arquivo PDF | *.pdf ";
            saveAs.DefaultExt = "pdf";
            saveAs.ShowDialog();
            dgvGrid.ExportToPdf(saveAs.FileName);

            System.Diagnostics.Process.Start(saveAs.FileName);
        }

        #endregion
    }
}

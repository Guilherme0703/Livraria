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
    public partial class frmMenu : Form
    {
        #region metodos do form
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Cadastros_Click(object sender, EventArgs e)
        {
            frmCadastro frmacionado = new frmCadastro();
            frmacionado.Show();
        }

        private void Consultas_Click(object sender, EventArgs e)
        {
            frmConsulta frmacionado = new frmConsulta();
            frmacionado.Show();
        }

        private void sair_Estoque_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}

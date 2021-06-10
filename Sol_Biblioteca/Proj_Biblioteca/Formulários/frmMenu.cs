using Proj_Biblioteca.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Biblioteca
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void lIVROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar a classe
            frmCadLivros objCadLivros = new frmCadLivros();
            objCadLivros.MdiParent = this;
            objCadLivros.Show();
        }

        private void pESSOASFILTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar a classe
            frmConsultaLivros objConsultaLivros = new frmConsultaLivros();
            objConsultaLivros.MdiParent = this;
            objConsultaLivros.Show();
        }

        private void lIVROS2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// Instanciar a classe
            //frmCadLivros2 objCadLivros = new frmCadLivros2();
            //objCadLivros.MdiParent = this;
            //objCadLivros.Show();
        }
    }
}

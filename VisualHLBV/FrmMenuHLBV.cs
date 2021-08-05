using System;
using Control;
using System.Linq;
using System.Windows.Forms;

namespace VisualHLBV
{
    public partial class FrmMenuHLBV : Form
    {
        AdmBecaInternacionalHLBV adm = AdmBecaInternacionalHLBV.GetAdm();
        public FrmMenuHLBV()
        {
            InitializeComponent();
        }

        private void mniRegistrar_Click(object sender, EventArgs e)
        {
            FrmBecaInternacionalHLBV frm = new FrmBecaInternacionalHLBV();
            frm.ShowDialog();
        }

        private void mniListar_Click(object sender, EventArgs e)
        {
            //FrmListarHLBV frm = new FrmListarHLBV();
            //frm.ShowDialog();
        }

        private void mniSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mniEliminar_Click(object sender, EventArgs e)
        {
            if (adm.TotalElementos() > 0)
            {
                FrmListarHLBV frm = new FrmListarHLBV();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No existen datos registrados");
            }
            
        }

        private void mniFiltrar_Click(object sender, EventArgs e)
        {
            if (adm.TotalElementos() > 0)
            {
                FrmFiltrarHLBV frm = new FrmFiltrarHLBV();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No existen datos registrados");
            }
        }

        private void mniVisualizar_Click(object sender, EventArgs e)
        {
            if (adm.TotalElementos() > 0)
            {
                FrmVisualizarBecaHLBV frm = new FrmVisualizarBecaHLBV();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existen datos registrados");
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adm.TotalElementos() > 0)
            {
                FrmEditarHLBV frm = new FrmEditarHLBV();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No existen datos registrados");
            }  
        }

        private void prácticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adm.TotalElementos() > 0)
            {
                FrmPracticaHLBV frm = new FrmPracticaHLBV();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No existen datos registrados");
            }
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adm.Conectar();
        }
    }
}


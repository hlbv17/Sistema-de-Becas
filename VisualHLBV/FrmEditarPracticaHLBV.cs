using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualHLBV
{
    public partial class FrmEditarPracticaHLBV : Form
    {
        AdmBecaInternacionalHLBV adm = AdmBecaInternacionalHLBV.GetAdm();
        public FrmEditarPracticaHLBV()
        {
            InitializeComponent();
        }

        public FrmEditarPracticaHLBV(DataGridView dgvBecaI)
        {
            InitializeComponent();
            adm.LlenarCampos(dgvBecaI, txtCedula, txtNombres, txtMonto, txtTiempo, cmbPais, cmbUniv, dtpFechaViaje,
               rdbInternacional, rdbNacional, pbFoto, lblFecha, lblPais);
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargarFoto = new OpenFileDialog();
            cargarFoto.InitialDirectory = "C:\\";
            cargarFoto.Filter = "Archivos *.jpg *.png |*.jpg; *.png";
            if (cargarFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.ImageLocation = cargarFoto.FileName;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) && c != ',' && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c) && c != ' ' && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text.Trim(), cedula = txtCedula.Text, universidad = cmbUniv.Text,
               monto = txtMonto.Text, tiempo = txtTiempo.Text, lugar = cmbPais.Text, foto = pbFoto.ImageLocation;
            DateTime fecha = dtpFechaViaje.Value.Date;
            adm.Modificar(cedula, nombre, monto, tiempo, fecha, lugar, universidad, rdbNacional, rdbInternacional, foto);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmPracticaHLBV frm = new FrmPracticaHLBV();
            frm.Visible = true;
            this.Visible = false;
        }
    }
}

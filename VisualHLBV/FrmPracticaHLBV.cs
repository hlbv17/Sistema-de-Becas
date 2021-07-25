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
    public partial class FrmPracticaHLBV : Form
    {
        AdmBecaInternacionalHLBV adm = AdmBecaInternacionalHLBV.GetAdm();
        public FrmPracticaHLBV()
        {
            InitializeComponent();
            adm.LlenarCmbPais(cmbPais);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string pais = cmbPais.Text, monto = txtMonto.Text.Trim(), dias = txtDias.Text.Trim();
            adm.Practica(pais, monto, dias, dgvBecaI);
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmEditarPracticaHLBV frm = new FrmEditarPracticaHLBV();
            frm = new FrmEditarPracticaHLBV(dgvBecaI);
            frm.Visible = true;
            this.Visible = false;
        }
    }
}

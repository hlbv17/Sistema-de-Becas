﻿using System;
using Control;
using System.Windows.Forms;

namespace VisualHLBV
{
    public partial class FrmVisualizarBecaHLBV : Form
    {
        AdmBecaInternacionalHLBV adm = AdmBecaInternacionalHLBV.GetAdm();
        public FrmVisualizarBecaHLBV()
        {
            InitializeComponent();
            //cmbBecas.Add("Valor");  AÑADIR UN ELEMENTO
            //cmbBecas.RemoveAt(1);   ELIMINAR UN ELEMENTO
            //cmbBecas.DataSource = adm.Lista;
            cmbBecas.DisplayMember = "Nombres";
            //cmbBecas.ValueMember = "NombreColumnaClave";   PARA TABLAS
        }

        private void rdbNacional_CheckedChanged(object sender, EventArgs e)
        {
            //picImage.Image = Ejercicio04HLBV.Properties.Resources.book_glasses_icon_icons_com_56355;
        }

        private void rdbInternacional_CheckedChanged(object sender, EventArgs e)
        {
            //picImage.Image = Ejercicio04HLBV.Properties.Resources.Untitled_design;
        }

        private void chkNacional_CheckedChanged(object sender, EventArgs e)
        {
            adm.TotalN(lblNacional, chkNacional);
        }

        private void chkInternacional_CheckedChanged(object sender, EventArgs e)
        {
            adm.TotalI(lblInternacional, chkInternacional);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indice = cmbBecas.SelectedIndex;
            adm.agregarV(lstNacional, lstInternacional, indice);
        }
    }
}

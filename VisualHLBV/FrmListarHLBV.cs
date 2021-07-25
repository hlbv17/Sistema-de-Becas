﻿using System;
using Control;
using System.Windows.Forms;

namespace VisualHLBV
{
    public partial class FrmListarHLBV : Form
    {
        AdmBecaInternacionalHLBV adm = AdmBecaInternacionalHLBV.GetAdm();
        public FrmListarHLBV()
        {
            InitializeComponent();
            adm.LlenarGrid(dtgvBecas, lblTotal);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion = dtgvBecas.CurrentRow.Index; //obtiene el indice de la fila seleccionada
            if (posicion >= 0)
            {
                adm.Eliminar(dtgvBecas, posicion, lblTotal);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_8
{
    public partial class MiPrimerControl : UserControl
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public event EventHandler FechaCambiada;

        public event EventHandler<MeCagoEnTusMuelasEventArgs> MeCagoEnTusMuelas;

        public MiPrimerControl()
        {
            InitializeComponent();

        }



        private void mcCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            FechaInicio = mcCalendario.SelectionStart;
            txtFechaInicio.Text = FechaInicio.ToShortDateString();

            FechaFin = mcCalendario.SelectionEnd;
            txtFechaFin.Text = FechaFin.ToShortDateString();

            FechaCambiada(this, e);
        }

        private void txtFechaInicio_TextChanged(object sender, EventArgs e)
        {
            MeCagoEnTusMuelasEventArgs pepe = new MeCagoEnTusMuelasEventArgs
            {
                ColorDeLasMuelas = "Amarillo",
                NumeroDeMuelas = 4
            };
            MeCagoEnTusMuelas(this, pepe);
        }
    }
}

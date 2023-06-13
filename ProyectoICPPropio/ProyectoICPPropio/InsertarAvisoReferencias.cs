using PROCEDIMIENTOS_LIB.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoICPPropio
{
    public partial class InsertarAvisoReferencias : Form
    {
        public AvisoRecepcionesLIN AvisoRecepcionesLIN { get; set; }

        public AvisoRecepcionesCAB AvisoRecepcionesCab { get; set; }

        public InsertarAvisoReferencias()
        {
            InitializeComponent();

            AvisoRecepcionesLIN = new AvisoRecepcionesLIN();
            AvisoRecepcionesCab = new AvisoRecepcionesCAB();

        }

        private void btnLinea_Click(object sender, EventArgs e)
        {


            AvisoRecepcionesLIN resultado = new AvisoRecepcionesLIN
            {
                ID_REFERENCIA = Convert.ToInt32(txtIdReferencia.Text),
                CANTIDAD = Convert.ToInt32(txtCantidad.Text),
                LOTE = txtLote.Text
            };

            AvisoRecepcionesLIN.Rellenar(AvisoRecepcionesLIN);

        }

        private void btnAceptarAviso_Click(object sender, EventArgs e)
        {
            if (txtCOD_PEDIDO.Text != null)
            {
                if (txtEstadoAviso.Text != null)
                {
                    AvisoRecepcionesCAB NuevoCab = new AvisoRecepcionesCAB
                    {
                        COD_PEDIDO = txtCOD_PEDIDO.Text,
                        ESTADO_AVISO = Convert.ToInt16(txtEstadoAviso.Text),
                        ID_PROVEEDOR = Convert.ToInt32(txtProveedor.Text),
                        TIPO_AVISO = Convert.ToInt16(txtTipo.Text)

                    };
                    AvisoRecepcionesCab.Rellenar(NuevoCab);
                }
                else
                    MessageBox.Show("El campo estado de aviso es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("El campo codigo de pedido es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}

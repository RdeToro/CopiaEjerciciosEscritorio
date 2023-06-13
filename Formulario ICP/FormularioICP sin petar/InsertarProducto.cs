using ProyectoICP_LIB.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioICP_sin_petar
{
    public partial class InsertarProducto : Form
    {
        public InsertarProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int Peso = 0;
            int Cantidad = 0;
            Producto_NEG producto = new Producto_NEG();

            if (txtCodigoReferencia.Text.Trim() != null)
                producto.CodReferencia = txtCodigoReferencia.Text;
            else
                MessageBox.Show("El código de referencia es un campo obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (txtDescripcion.Text.Trim() != null)
                producto.Descripcion = txtDescripcion.Text;
            else
                producto.Descripcion = String.Empty;

            if (txtRefCliente.Text.Trim() != null)
                producto.RefCliente = txtRefCliente.Text;

            if (txtEAN.Text.Trim() != null)
                producto.CodEan = txtEAN.Text;

            if (txtIdGrupo.Text.Trim() != null)
                producto.GrupoID = txtIdGrupo.Text;

            if (txtCntEstadar.Text.Trim() != null)
            {
                Cantidad = Convert.ToInt32(txtCntEstadar.Text);
                producto.CantidadSTD = Cantidad;
            }

            if (txtPeso.Text.Trim() != null)
            {
                Peso = Convert.ToInt32(txtPeso.Text);

                producto.Peso = Peso;

            }
            else
            {
                Peso = 0;
                producto.Peso = Peso;
            }

            if(rbSi.Checked == true)
            {
                producto.Operativa = true;
            }
            else if(rbNo.Checked == true)
            {
                producto.Operativa = false;
            }

            if (txtLongitudNSerie.Text.Trim() != null)
            {
                producto.LongNUmSerie = txtLongitudNSerie.TextLength;
            }
            else
                producto.LongNUmSerie = 0;

            producto.Rellenar(producto);
            
        }

        
    }
}

using ProyectoICP_LIB.NEGOCIO;

namespace FormularioICP_sin_petar
{
    public partial class Inicio : Form
    {
        Aviso_Recepciones_CAB_NEG _avisoRecepcionCab = new Aviso_Recepciones_CAB_NEG();
        Producto_NEG _misProductos = new Producto_NEG();
        public Inicio()
        {
            InitializeComponent();

            dgvReferencias.DataSource = _misProductos.GetProductos();

        }

        private void insertarReferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarProducto VentanaInsertar = new InsertarProducto();

            VentanaInsertar.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int IdReferencia = 0;
            List<Producto_NEG> Buscado = new List<Producto_NEG>();
            if (txtIdReferencia.Text != null)
            {
                IdReferencia = Convert.ToInt32(txtIdReferencia.Text);
                if (IdReferencia > 0)
                {
                    Buscado = _misProductos.GetProducto(IdReferencia);
                }
            }
            dgvReferencias.DataSource = Buscado;

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dgvReferencias.DataSource = _misProductos.GetProductos();
        }


        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvReferencias.DataSource = _avisoRecepcionCab.GetAvisoRecepcionesCAB();
        }
    }
}
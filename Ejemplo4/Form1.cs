using System.Data;

namespace Ejemplo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable miTabla = new DataTable();

            miTabla.Columns.Add("Id", typeof(int));
            miTabla.Columns.Add("Nombre", typeof(string));
            miTabla.Columns.Add("Apellidos", typeof(string));
            miTabla.Columns.Add("Edad", typeof(int));

            DataRow miFila = miTabla.NewRow();
            miFila["Id"] = 1;
            miFila["Nombre"] = "Pepe";
            miFila["Apellidos"] = "Lopez";
            miFila["Edad"] = 34;

            miTabla.Rows.Add(miFila);

            miFila = miTabla.NewRow();
            miFila["Id"] = 2;
            miFila["Nombre"] = "Lola";
            miFila["Apellidos"] = "Jimenez";
            miFila["Edad"] = 27;

            miTabla.Rows.Add(miFila);

            DataSet ds = new DataSet();
            ds.Tables.Add(miTabla);

            dgvDatosPersonas.DataSource = miTabla;
        }
    }
}
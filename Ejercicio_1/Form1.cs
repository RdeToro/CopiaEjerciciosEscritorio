using _LIBCoches;

namespace Ejercicio_1
{
    /// <summary>
    /// Aplicación para crear objetos de tipo coche y rellenar un 
    /// desplegable de forma dinámica
    /// </summary>
    public partial class Form1 : Form
    {
        public List<Coche> MisCoches { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Coches coches = new Coches();
            MisCoches = coches.ListaCoches;

            RecargarComboCoches();
            //cboCoches.DataSource = MisCoches;
            //cboCoches.DisplayMember = "MarcaModelo";
            //cboCoches.ValueMember = "Id";
        }

        private void btnAddCoche_Click(object sender, EventArgs e)
        {
            string Mensaje = String.Empty;

            // 1. Que los campos estén rellenos
            if (String.IsNullOrEmpty(txtId.Text))
                Mensaje = "El campo Id es obligatorio";
            else if(String.IsNullOrEmpty(txtMarca.Text))
                Mensaje = "El campo Marca es obligatorio";
            else if (String.IsNullOrEmpty(txtModelo.Text))
                Mensaje = "El campo Modelo es obligatorio";

            if (Mensaje.Length > 0)
                MessageBox.Show(Mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Entra aquí cuando todos los campos están rellenos

                // 2. Que el ID del nuevo objeto, no exista
                Coche buscado = (from c in MisCoches
                                where c.Id.ToString() == txtId.Text.Trim()
                                select c).FirstOrDefault();

                if (buscado != null)
                    MessageBox.Show("No se puede crear un coche con el mismo Id", "ERROR", 
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    // Que el ID no existe todavía

                    // 3. Crear el objeto coche
                    Coche nuevo = new Coche
                    {
                        Id = Convert.ToInt32(txtId.Text),
                        Marca = txtMarca.Text,
                        Modelo = txtModelo.Text
                    };

                    // 4. Añadirlo a la colección de coches
                    MisCoches.Add(nuevo);

                    // 5. Recargar el desplegable
                    RecargarComboCoches();
                    //cboCoches.DataSource = null;
                    //cboCoches.DataSource = MisCoches;
                    //cboCoches.DisplayMember = "MarcaModelo";
                    //cboCoches.ValueMember = "Id";
                }

            }

        }

        private void RecargarComboCoches()
        {
            cboCoches.DataSource = null;
            cboCoches.DataSource = MisCoches;
            cboCoches.DisplayMember = "MarcaModelo";
            cboCoches.ValueMember = "Id";
        }
    }
}
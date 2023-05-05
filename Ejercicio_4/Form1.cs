using _LIBGeoClases.NEGOCIO;
using Ejercicio_4_LIB.NEGOCIO;

namespace Ejercicio_4
{
    /*
    Crear un formulario para dar de alta Centros de trabajo.
    El formulario tendrá los siguientes controles:
    Comunidad: Lista de Comunidades Autónomas extraidos de la BBDD
    Provincia: En función de la Comunidad seleccionada, se rellenará con información de la BBDD
    Municipio: En función de la provincia seleccionada, se rellenará con información de la BBDD
    Población: En función del Municipio seleccionado, se rellenará con información de la BBDD
    Centro: Nombre del centro de trabajo a crear
     */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Comunidad comunidad = new Comunidad();
            List<Comunidad> lstComunidades = comunidad.GetComunidades_Negocio();

            Comunidad objetoVacio = new Comunidad
            {
                Id = 0,
                Nombre = ""
            };

            lstComunidades.Insert(0, objetoVacio);

            cboComunidad.DataSource = lstComunidades.OrderBy(x => x.Nombre).ToList();
            cboComunidad.DisplayMember = "Nombre";
            cboComunidad.ValueMember = "Id";
        }

        private void cboComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cboControl = (ComboBox)sender;
            Comunidad comunidad = (Comunidad)cboControl.SelectedItem;

            Provincia provincia = new Provincia();
            List<Provincia> lstProvincias = provincia.GetProvinciasPorComunidadId_Negocio(comunidad.Id);

            Provincia objetoVacio = new Provincia
            {
                Id = 0,
                Nombre = ""
            };

            lstProvincias.Insert(0, objetoVacio);

            cboProvincia.DataSource = lstProvincias.OrderBy(p => p.Nombre).ToList(); ;
            cboProvincia.DisplayMember = "Nombre";
            cboProvincia.ValueMember = "Id";
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbControl = (ComboBox)sender;
            Provincia provincia = (Provincia)cbControl.SelectedItem;

            Municipio municipio = new Municipio();
            List<Municipio> lstMunicipios = municipio.GetMunicipiosPorProvinciaId_Negocio(provincia.Id);

            Municipio objetoVacio = new Municipio
            {
                Id = 0,
                Nombre = ""
            };

            lstMunicipios.Insert(0, objetoVacio);

            cboMunicipio.DataSource = lstMunicipios.OrderBy(m => m.Nombre).ToList();
            cboMunicipio.DisplayMember = "Nombre";
            cboMunicipio.ValueMember = "Id";
        }

        private void cboMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Municipio municipio = (Municipio)comboBox.SelectedItem;

            Poblacion poblacion = new Poblacion();
            List<Poblacion> lstPoblaciones = poblacion.GetPoblacionesPorMunicipioId_Negocio(municipio.Id);

            Poblacion objetoVacio = new Poblacion
            {
                Id = 0,
                Nombre = ""
            };

            lstPoblaciones.Insert(0, objetoVacio);

            cboPoblacion.DataSource = lstPoblaciones;
            cboPoblacion.DisplayMember = "Nombre";
            cboPoblacion.ValueMember = "Id";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool Relleno = true;

            if (cboPoblacion.SelectedIndex <= 0)
                Relleno = false;

            if (Relleno)
            {
                if (txtCentro.Text.Trim() == String.Empty)
                    Relleno = false;
            }

            if (Relleno)
            {
                if (txtDireccion.Text.Trim() == String.Empty)
                    Relleno = false;
            }

            if (Relleno)
            {
                if (txtCodigoPostal.Text.Trim() == String.Empty)
                    Relleno = false;
            }

            if (Relleno)
            {
                Poblacion poblacion = (Poblacion)cboPoblacion.SelectedItem;

                Centro centro = new Centro
                {
                    Nombre = txtCentro.Text,
                    Direccion = txtDireccion.Text,
                    CodigoPostal = int.Parse(txtCodigoPostal.Text),
                    PoblacionId = poblacion.Id
                };

                MessageBox.Show("Centro creado correctamente", "Centro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Faltan campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
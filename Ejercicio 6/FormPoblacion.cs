using _LIBGeoClases.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class FormPoblacion : Form
    {
        public int MuncipioID { get; set; }
        public FormPoblacion(int IdMunicipio)
        {
            InitializeComponent();
            MuncipioID = IdMunicipio;

            Poblacion miPoblacion = new Poblacion();
            List<Poblacion> Poblacion = miPoblacion.GetPoblacionesPorMunicipioId_Negocio(MuncipioID);
            dgvPoblaciones.DataSource = Poblacion;
        }
    }
}

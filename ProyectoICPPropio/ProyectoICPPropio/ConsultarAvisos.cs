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
    public partial class ConsultarAvisos : Form
    {
        ConexionConDatos consultas;
        public ConsultarAvisos()
        {
            InitializeComponent();

            if (consultas != null)
            {
                dgvConsultar.DataSource = consultas.misCabeceras;
            }
        }
    }
}

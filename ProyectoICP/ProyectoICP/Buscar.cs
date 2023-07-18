using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoICP.Hijos
{
    public partial class Filtrar : Form
    {

        public Filtrar(List<string> Categorias)
        {
            InitializeComponent();

            List<string> categorias = Categorias;

            cbCatergoria.Items.Add(categorias);
            cbCatergoria.Items.Insert(0, "");
        }
    }
}

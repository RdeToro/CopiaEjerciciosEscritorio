using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3
{
    public partial class FormularioMDI : Form
    {
        public FormularioMDI()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void mnuFormulario1_Click(object sender, EventArgs e)
        {
            Form1 frmFormulario1 = new Form1();
            frmFormulario1.MdiParent = this;
            frmFormulario1.Show();
        }

        private void mnuFormulario2_Click(object sender, EventArgs e)
        {
            Form2 frmFormulario2 = new Form2();
            frmFormulario2.MdiParent = this;
            frmFormulario2.Show();
        }

        private void formulario3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frmFormulario3 = new Form3();
            frmFormulario3.MdiParent = this;
            frmFormulario3.Show();
        }

        private void formulario4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frmFormulario4 = new Form4();
            frmFormulario4.MdiParent = this;
            frmFormulario4.Show();
        }
    }
}

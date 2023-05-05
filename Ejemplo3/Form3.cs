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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            TextBox miCajaDeTexto = new TextBox();
            miCajaDeTexto.Name = "txtCaja1";
            miCajaDeTexto.Text = "Este es el texto de la caja";
            miCajaDeTexto.Width = 150;
            miCajaDeTexto.Height = 10;
            miCajaDeTexto.BackColor = Color.Aqua;
            miCajaDeTexto.Top = 5;
            miCajaDeTexto.Left = 5;

            panel1.Controls.Add(miCajaDeTexto);

            miCajaDeTexto = new TextBox();
            miCajaDeTexto.Name = "txtCaja2";
            miCajaDeTexto.Text = "Este es el texto de la caja";
            miCajaDeTexto.Width = 150;
            miCajaDeTexto.Height = 10;
            miCajaDeTexto.BackColor = Color.Azure;
            miCajaDeTexto.Top = 30;
            miCajaDeTexto.Left = 5;

            panel1.Controls.Add(miCajaDeTexto);

            Button miBoton = new Button();
            miBoton.Name = "btnMiBoton";
            miBoton.Text = "Dale caña";
            miBoton.Width = 100;
            miBoton.Height = 50;
            miBoton.Top = 60;
            miBoton.Left = 5;
            miBoton.Click += miBoton_Click;

            panel1.Controls.Add(miBoton);

            CheckBox miCheckBox = new CheckBox();
            miCheckBox.Text = "Esto es un check box";
            miCheckBox.Top = 120;
            miCheckBox.Left = 5;
            miCheckBox.CheckedChanged += miCheckBox_CheckedChange;

            panel1.Controls.Add(miCheckBox);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void miCheckBox_CheckedChange(object sender, EventArgs e)
        {
            CheckBox temp = (CheckBox)sender;
            if (temp.Checked)
            {
                MessageBox.Show("Está marcado");
            }
            else
            {
                MessageBox.Show("Está desmarcado");
            }
        }

        private void miBoton_Click(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)panel1.Controls["txtCaja2"];
            temp.Text = String.Empty;

            temp = (TextBox)panel1.Controls["txtCaja1"];
            temp.Text = String.Empty;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

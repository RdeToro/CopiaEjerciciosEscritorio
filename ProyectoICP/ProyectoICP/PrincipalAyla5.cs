using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoICP
{
    public partial class PrincipalAyla5 : Form
    {
        private Form Abierto = null;
        public PrincipalAyla5()
        {
            InitializeComponent();
            Diseño();
        }


        private void Diseño()
        {
            panelOrdenesSalida.Visible = false;
            panelRecepciones.Visible = false;
            panelAlmacen.Visible = false;
        }

        private void EsconderSubMenu()
        {
            if(panelOrdenesSalida.Visible==true) 
                panelOrdenesSalida.Visible=false;
            if(panelAlmacen.Visible==true)
                panelAlmacen.Visible = false;
            if(panelRecepciones.Visible==true)
                panelRecepciones.Visible = false;
              
        }

        private void VerSubMenu(Panel submenu)
        {
            if(submenu.Visible==true)
            {
                EsconderSubMenu();                
            }
                
            if(submenu.Visible ==false)
            {
                EsconderSubMenu();
                submenu.Visible = true;
            }
        }

        
        private void AbrirHijo(Form hijo)
        {
            if(Abierto != null)
            {
                Abierto.Close();
            }
            Abierto= hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(hijo);            
            panelHijo.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void btnReferencias_Click(object sender, EventArgs e)
        {
            Referencias referencias = new Referencias();
            this.AbrirHijo(referencias);
            EsconderSubMenu();
        }

        private void btnRecepciones_Click(object sender, EventArgs e)
        {
            VerSubMenu(panelRecepciones);
            //
        }

        private void btnVerRecepciones_Click(object sender, EventArgs e)
        {
            //
            EsconderSubMenu();
        }
        
        private void btnConfirmarRecepcion_Click(object sender, EventArgs e)
        {
            //
            EsconderSubMenu();

        }
        private void btnOrdenesSalida_Click(object sender, EventArgs e)
        {
            VerSubMenu(panelOrdenesSalida);
            //
        }

        private void btnVerOrdenes_Click(object sender, EventArgs e)
        {
            //
            EsconderSubMenu();
        }

        private void btnAsignarPale_Click(object sender, EventArgs e)
        {
            //
            EsconderSubMenu();
        }   

        private void btnPicking_Click(object sender, EventArgs e)
        {
            //
            EsconderSubMenu();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            //
            VerSubMenu(panelAlmacen);
        }

        private void btnPalets_Click(object sender, EventArgs e)
        {
            //
            EsconderSubMenu();
        }

        private void btnUbicaciones_Click(object sender, EventArgs e)
        {
            //
            EsconderSubMenu();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            //
            EsconderSubMenu();
        }
    }
}

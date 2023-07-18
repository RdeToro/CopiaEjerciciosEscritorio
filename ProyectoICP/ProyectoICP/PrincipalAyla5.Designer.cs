namespace ProyectoICP
{
    partial class PrincipalAyla5
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalAyla5));
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.panelAlmacen = new System.Windows.Forms.Panel();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnUbicaciones = new System.Windows.Forms.Button();
            this.btnPalets = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.panelOrdenesSalida = new System.Windows.Forms.Panel();
            this.btnPicking = new System.Windows.Forms.Button();
            this.btnAsignarPaleEnvio = new System.Windows.Forms.Button();
            this.btnVerOrdenes = new System.Windows.Forms.Button();
            this.btnOrdenesSalida = new System.Windows.Forms.Button();
            this.panelRecepciones = new System.Windows.Forms.Panel();
            this.btnConfirmarRecepcion = new System.Windows.Forms.Button();
            this.btnVerRecepciones = new System.Windows.Forms.Button();
            this.btnRecepciones = new System.Windows.Forms.Button();
            this.btnReferencias = new System.Windows.Forms.Button();
            this.panelHijo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuPrincipal.SuspendLayout();
            this.panelAlmacen.SuspendLayout();
            this.panelOrdenesSalida.SuspendLayout();
            this.panelRecepciones.SuspendLayout();
            this.panelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.AutoScroll = true;
            this.panelMenuPrincipal.BackColor = System.Drawing.Color.Silver;
            this.panelMenuPrincipal.Controls.Add(this.panelAlmacen);
            this.panelMenuPrincipal.Controls.Add(this.btnAlmacen);
            this.panelMenuPrincipal.Controls.Add(this.panelOrdenesSalida);
            this.panelMenuPrincipal.Controls.Add(this.btnOrdenesSalida);
            this.panelMenuPrincipal.Controls.Add(this.panelRecepciones);
            this.panelMenuPrincipal.Controls.Add(this.btnRecepciones);
            this.panelMenuPrincipal.Controls.Add(this.btnReferencias);
            this.panelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelMenuPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(277, 655);
            this.panelMenuPrincipal.TabIndex = 0;
            // 
            // panelAlmacen
            // 
            this.panelAlmacen.Controls.Add(this.btnMovimientos);
            this.panelAlmacen.Controls.Add(this.btnUbicaciones);
            this.panelAlmacen.Controls.Add(this.btnPalets);
            this.panelAlmacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlmacen.Location = new System.Drawing.Point(0, 510);
            this.panelAlmacen.Name = "panelAlmacen";
            this.panelAlmacen.Size = new System.Drawing.Size(260, 150);
            this.panelAlmacen.TabIndex = 7;
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.BackColor = System.Drawing.Color.Blue;
            this.btnMovimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMovimientos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMovimientos.Location = new System.Drawing.Point(0, 100);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMovimientos.Size = new System.Drawing.Size(260, 50);
            this.btnMovimientos.TabIndex = 2;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimientos.UseVisualStyleBackColor = false;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnUbicaciones
            // 
            this.btnUbicaciones.BackColor = System.Drawing.Color.Blue;
            this.btnUbicaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUbicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUbicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUbicaciones.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUbicaciones.Location = new System.Drawing.Point(0, 50);
            this.btnUbicaciones.Name = "btnUbicaciones";
            this.btnUbicaciones.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUbicaciones.Size = new System.Drawing.Size(260, 50);
            this.btnUbicaciones.TabIndex = 1;
            this.btnUbicaciones.Text = "Ubicaciones";
            this.btnUbicaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbicaciones.UseVisualStyleBackColor = false;
            this.btnUbicaciones.Click += new System.EventHandler(this.btnUbicaciones_Click);
            // 
            // btnPalets
            // 
            this.btnPalets.BackColor = System.Drawing.Color.Blue;
            this.btnPalets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPalets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPalets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPalets.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPalets.Location = new System.Drawing.Point(0, 0);
            this.btnPalets.Name = "btnPalets";
            this.btnPalets.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPalets.Size = new System.Drawing.Size(260, 50);
            this.btnPalets.TabIndex = 0;
            this.btnPalets.Text = "Palets";
            this.btnPalets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPalets.UseVisualStyleBackColor = false;
            this.btnPalets.Click += new System.EventHandler(this.btnPalets_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAlmacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnAlmacen.Location = new System.Drawing.Point(0, 445);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAlmacen.Size = new System.Drawing.Size(260, 65);
            this.btnAlmacen.TabIndex = 6;
            this.btnAlmacen.Text = "Almacen";
            this.btnAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.UseVisualStyleBackColor = false;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // panelOrdenesSalida
            // 
            this.panelOrdenesSalida.Controls.Add(this.btnPicking);
            this.panelOrdenesSalida.Controls.Add(this.btnAsignarPaleEnvio);
            this.panelOrdenesSalida.Controls.Add(this.btnVerOrdenes);
            this.panelOrdenesSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrdenesSalida.Location = new System.Drawing.Point(0, 295);
            this.panelOrdenesSalida.Margin = new System.Windows.Forms.Padding(4);
            this.panelOrdenesSalida.Name = "panelOrdenesSalida";
            this.panelOrdenesSalida.Size = new System.Drawing.Size(260, 150);
            this.panelOrdenesSalida.TabIndex = 5;
            // 
            // btnPicking
            // 
            this.btnPicking.BackColor = System.Drawing.Color.Blue;
            this.btnPicking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPicking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPicking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPicking.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPicking.Location = new System.Drawing.Point(0, 100);
            this.btnPicking.Name = "btnPicking";
            this.btnPicking.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPicking.Size = new System.Drawing.Size(260, 50);
            this.btnPicking.TabIndex = 2;
            this.btnPicking.Text = "Picking";
            this.btnPicking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPicking.UseVisualStyleBackColor = false;
            this.btnPicking.Click += new System.EventHandler(this.btnPicking_Click);
            // 
            // btnAsignarPaleEnvio
            // 
            this.btnAsignarPaleEnvio.BackColor = System.Drawing.Color.Blue;
            this.btnAsignarPaleEnvio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignarPaleEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignarPaleEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAsignarPaleEnvio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAsignarPaleEnvio.Location = new System.Drawing.Point(0, 50);
            this.btnAsignarPaleEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignarPaleEnvio.Name = "btnAsignarPaleEnvio";
            this.btnAsignarPaleEnvio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAsignarPaleEnvio.Size = new System.Drawing.Size(260, 50);
            this.btnAsignarPaleEnvio.TabIndex = 1;
            this.btnAsignarPaleEnvio.Text = "Asignar stock";
            this.btnAsignarPaleEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarPaleEnvio.UseVisualStyleBackColor = false;
            this.btnAsignarPaleEnvio.Click += new System.EventHandler(this.btnAsignarPale_Click);
            // 
            // btnVerOrdenes
            // 
            this.btnVerOrdenes.BackColor = System.Drawing.Color.Blue;
            this.btnVerOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnVerOrdenes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerOrdenes.Location = new System.Drawing.Point(0, 0);
            this.btnVerOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerOrdenes.Name = "btnVerOrdenes";
            this.btnVerOrdenes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVerOrdenes.Size = new System.Drawing.Size(260, 50);
            this.btnVerOrdenes.TabIndex = 0;
            this.btnVerOrdenes.Text = "Ver ordenes";
            this.btnVerOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerOrdenes.UseVisualStyleBackColor = false;
            this.btnVerOrdenes.Click += new System.EventHandler(this.btnVerOrdenes_Click);
            // 
            // btnOrdenesSalida
            // 
            this.btnOrdenesSalida.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOrdenesSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenesSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenesSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOrdenesSalida.ForeColor = System.Drawing.Color.White;
            this.btnOrdenesSalida.Location = new System.Drawing.Point(0, 230);
            this.btnOrdenesSalida.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenesSalida.Name = "btnOrdenesSalida";
            this.btnOrdenesSalida.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrdenesSalida.Size = new System.Drawing.Size(260, 65);
            this.btnOrdenesSalida.TabIndex = 4;
            this.btnOrdenesSalida.Text = "Ordenes de salida";
            this.btnOrdenesSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenesSalida.UseVisualStyleBackColor = false;
            this.btnOrdenesSalida.Click += new System.EventHandler(this.btnOrdenesSalida_Click);
            // 
            // panelRecepciones
            // 
            this.panelRecepciones.Controls.Add(this.btnConfirmarRecepcion);
            this.panelRecepciones.Controls.Add(this.btnVerRecepciones);
            this.panelRecepciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecepciones.Location = new System.Drawing.Point(0, 130);
            this.panelRecepciones.Margin = new System.Windows.Forms.Padding(4);
            this.panelRecepciones.Name = "panelRecepciones";
            this.panelRecepciones.Size = new System.Drawing.Size(260, 100);
            this.panelRecepciones.TabIndex = 3;
            // 
            // btnConfirmarRecepcion
            // 
            this.btnConfirmarRecepcion.BackColor = System.Drawing.Color.Blue;
            this.btnConfirmarRecepcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfirmarRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConfirmarRecepcion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirmarRecepcion.Location = new System.Drawing.Point(0, 50);
            this.btnConfirmarRecepcion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            this.btnConfirmarRecepcion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConfirmarRecepcion.Size = new System.Drawing.Size(260, 50);
            this.btnConfirmarRecepcion.TabIndex = 1;
            this.btnConfirmarRecepcion.Text = "Confirmar recepcion";
            this.btnConfirmarRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarRecepcion.UseVisualStyleBackColor = false;
            this.btnConfirmarRecepcion.Click += new System.EventHandler(this.btnConfirmarRecepcion_Click);
            // 
            // btnVerRecepciones
            // 
            this.btnVerRecepciones.BackColor = System.Drawing.Color.Blue;
            this.btnVerRecepciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerRecepciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerRecepciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnVerRecepciones.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerRecepciones.Location = new System.Drawing.Point(0, 0);
            this.btnVerRecepciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerRecepciones.Name = "btnVerRecepciones";
            this.btnVerRecepciones.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVerRecepciones.Size = new System.Drawing.Size(260, 50);
            this.btnVerRecepciones.TabIndex = 0;
            this.btnVerRecepciones.Text = "Ver recepciones";
            this.btnVerRecepciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerRecepciones.UseVisualStyleBackColor = false;
            this.btnVerRecepciones.Click += new System.EventHandler(this.btnVerRecepciones_Click);
            // 
            // btnRecepciones
            // 
            this.btnRecepciones.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRecepciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecepciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRecepciones.ForeColor = System.Drawing.Color.White;
            this.btnRecepciones.Location = new System.Drawing.Point(0, 65);
            this.btnRecepciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecepciones.Name = "btnRecepciones";
            this.btnRecepciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRecepciones.Size = new System.Drawing.Size(260, 65);
            this.btnRecepciones.TabIndex = 2;
            this.btnRecepciones.Text = "Recepciones";
            this.btnRecepciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecepciones.UseVisualStyleBackColor = false;
            this.btnRecepciones.Click += new System.EventHandler(this.btnRecepciones_Click);
            // 
            // btnReferencias
            // 
            this.btnReferencias.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReferencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReferencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReferencias.ForeColor = System.Drawing.Color.White;
            this.btnReferencias.Location = new System.Drawing.Point(0, 0);
            this.btnReferencias.Margin = new System.Windows.Forms.Padding(4);
            this.btnReferencias.Name = "btnReferencias";
            this.btnReferencias.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReferencias.Size = new System.Drawing.Size(260, 65);
            this.btnReferencias.TabIndex = 1;
            this.btnReferencias.Text = "Referencias";
            this.btnReferencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReferencias.UseVisualStyleBackColor = false;
            this.btnReferencias.Click += new System.EventHandler(this.btnReferencias_Click);
            // 
            // panelHijo
            // 
            this.panelHijo.Controls.Add(this.pictureBox1);
            this.panelHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHijo.Location = new System.Drawing.Point(277, 0);
            this.panelHijo.Name = "panelHijo";
            this.panelHijo.Size = new System.Drawing.Size(1047, 655);
            this.panelHijo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoICP.Properties.Resources.ICP_fav_edge;
            this.pictureBox1.Location = new System.Drawing.Point(364, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 258);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PrincipalAyla5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 655);
            this.Controls.Add(this.panelHijo);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrincipalAyla5";
            this.Text = "Inicio";
            this.panelMenuPrincipal.ResumeLayout(false);
            this.panelAlmacen.ResumeLayout(false);
            this.panelOrdenesSalida.ResumeLayout(false);
            this.panelRecepciones.ResumeLayout(false);
            this.panelHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Button btnReferencias;
        private System.Windows.Forms.Panel panelRecepciones;
        private System.Windows.Forms.Button btnRecepciones;
        private System.Windows.Forms.Button btnVerRecepciones;
        private System.Windows.Forms.Button btnConfirmarRecepcion;
        private System.Windows.Forms.Button btnOrdenesSalida;
        private System.Windows.Forms.Panel panelOrdenesSalida;
        private System.Windows.Forms.Button btnVerOrdenes;
        private System.Windows.Forms.Button btnAsignarPaleEnvio;
        private System.Windows.Forms.Button btnPicking;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Panel panelAlmacen;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnUbicaciones;
        private System.Windows.Forms.Button btnPalets;
        private System.Windows.Forms.Panel panelHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


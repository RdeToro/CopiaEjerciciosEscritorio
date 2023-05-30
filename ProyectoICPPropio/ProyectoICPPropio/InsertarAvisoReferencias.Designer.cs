namespace ProyectoICPPropio
{
    partial class InsertarAvisoReferencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEstadoAviso = new Label();
            txtEstadoAviso = new TextBox();
            lblCOD_PEDIDO = new Label();
            txtCOD_PEDIDO = new TextBox();
            lbl_Id_Proveedor = new Label();
            txtProveedor = new TextBox();
            lblTipoAviso = new Label();
            txtTipo = new TextBox();
            lblIDReferencia = new Label();
            txtIdReferencia = new TextBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblLote = new Label();
            txtLote = new TextBox();
            btnLinea = new Button();
            btnAceptarAviso = new Button();
            SuspendLayout();
            // 
            // lblEstadoAviso
            // 
            lblEstadoAviso.AutoSize = true;
            lblEstadoAviso.Location = new Point(12, 36);
            lblEstadoAviso.Name = "lblEstadoAviso";
            lblEstadoAviso.Size = new Size(96, 15);
            lblEstadoAviso.TabIndex = 0;
            lblEstadoAviso.Text = "Estado de Aviso: ";
            // 
            // txtEstadoAviso
            // 
            txtEstadoAviso.Location = new Point(12, 54);
            txtEstadoAviso.Name = "txtEstadoAviso";
            txtEstadoAviso.Size = new Size(195, 23);
            txtEstadoAviso.TabIndex = 1;
            // 
            // lblCOD_PEDIDO
            // 
            lblCOD_PEDIDO.AutoSize = true;
            lblCOD_PEDIDO.Location = new Point(12, 89);
            lblCOD_PEDIDO.Name = "lblCOD_PEDIDO";
            lblCOD_PEDIDO.Size = new Size(108, 15);
            lblCOD_PEDIDO.TabIndex = 2;
            lblCOD_PEDIDO.Text = "Codigo de pedido: ";
            // 
            // txtCOD_PEDIDO
            // 
            txtCOD_PEDIDO.Location = new Point(12, 107);
            txtCOD_PEDIDO.Name = "txtCOD_PEDIDO";
            txtCOD_PEDIDO.Size = new Size(195, 23);
            txtCOD_PEDIDO.TabIndex = 3;
            // 
            // lbl_Id_Proveedor
            // 
            lbl_Id_Proveedor.AutoSize = true;
            lbl_Id_Proveedor.Location = new Point(12, 145);
            lbl_Id_Proveedor.Name = "lbl_Id_Proveedor";
            lbl_Id_Proveedor.Size = new Size(81, 15);
            lbl_Id_Proveedor.TabIndex = 4;
            lbl_Id_Proveedor.Text = "Proveedor ID: ";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(12, 163);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(195, 23);
            txtProveedor.TabIndex = 5;
            // 
            // lblTipoAviso
            // 
            lblTipoAviso.AutoSize = true;
            lblTipoAviso.Location = new Point(12, 197);
            lblTipoAviso.Name = "lblTipoAviso";
            lblTipoAviso.Size = new Size(84, 15);
            lblTipoAviso.TabIndex = 6;
            lblTipoAviso.Text = "Tipo de Aviso: ";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(12, 215);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(195, 23);
            txtTipo.TabIndex = 7;
            // 
            // lblIDReferencia
            // 
            lblIDReferencia.AutoSize = true;
            lblIDReferencia.Location = new Point(264, 36);
            lblIDReferencia.Name = "lblIDReferencia";
            lblIDReferencia.Size = new Size(94, 15);
            lblIDReferencia.TabIndex = 8;
            lblIDReferencia.Text = "Id de referencia: ";
            // 
            // txtIdReferencia
            // 
            txtIdReferencia.Location = new Point(264, 54);
            txtIdReferencia.Name = "txtIdReferencia";
            txtIdReferencia.Size = new Size(184, 23);
            txtIdReferencia.TabIndex = 9;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(264, 89);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(61, 15);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad: ";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(264, 107);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 11;
            // 
            // lblLote
            // 
            lblLote.AutoSize = true;
            lblLote.Location = new Point(264, 145);
            lblLote.Name = "lblLote";
            lblLote.Size = new Size(36, 15);
            lblLote.TabIndex = 12;
            lblLote.Text = "Lote: ";
            // 
            // txtLote
            // 
            txtLote.Location = new Point(264, 163);
            txtLote.Name = "txtLote";
            txtLote.Size = new Size(100, 23);
            txtLote.TabIndex = 13;
            // 
            // btnLinea
            // 
            btnLinea.Location = new Point(264, 197);
            btnLinea.Name = "btnLinea";
            btnLinea.Size = new Size(110, 23);
            btnLinea.TabIndex = 14;
            btnLinea.Text = "Agregar Linea";
            btnLinea.UseVisualStyleBackColor = true;
            btnLinea.Click += btnLinea_Click;
            // 
            // btnAceptarAviso
            // 
            btnAceptarAviso.Location = new Point(200, 264);
            btnAceptarAviso.Name = "btnAceptarAviso";
            btnAceptarAviso.Size = new Size(75, 23);
            btnAceptarAviso.TabIndex = 15;
            btnAceptarAviso.Text = "Aceptar";
            btnAceptarAviso.UseVisualStyleBackColor = true;
            btnAceptarAviso.Click += btnAceptarAviso_Click;
            // 
            // AvisoReferencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 309);
            Controls.Add(btnAceptarAviso);
            Controls.Add(btnLinea);
            Controls.Add(txtLote);
            Controls.Add(lblLote);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtIdReferencia);
            Controls.Add(lblIDReferencia);
            Controls.Add(txtTipo);
            Controls.Add(lblTipoAviso);
            Controls.Add(txtProveedor);
            Controls.Add(lbl_Id_Proveedor);
            Controls.Add(txtCOD_PEDIDO);
            Controls.Add(lblCOD_PEDIDO);
            Controls.Add(txtEstadoAviso);
            Controls.Add(lblEstadoAviso);
            Name = "AvisoReferencias";
            Text = "AvisoReferencias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstadoAviso;
        private TextBox txtEstadoAviso;
        private Label lblCOD_PEDIDO;
        private TextBox txtCOD_PEDIDO;
        private Label lbl_Id_Proveedor;
        private TextBox txtProveedor;
        private Label lblTipoAviso;
        private TextBox txtTipo;
        private Label lblIDReferencia;
        private TextBox txtIdReferencia;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblLote;
        private TextBox txtLote;
        private Button btnLinea;
        private Button btnAceptarAviso;
    }
}
namespace Ejercicio_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblComunidad = new Label();
            cboComunidad = new ComboBox();
            lblProvincia = new Label();
            cboProvincia = new ComboBox();
            lblMunicipio = new Label();
            cboMunicipio = new ComboBox();
            lblPoblacion = new Label();
            cboPoblacion = new ComboBox();
            lblCentro = new Label();
            txtCentro = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblCP = new Label();
            btnAceptar = new Button();
            txtCodigoPostal = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblComunidad
            // 
            lblComunidad.AutoSize = true;
            lblComunidad.Location = new Point(15, 11);
            lblComunidad.Name = "lblComunidad";
            lblComunidad.Size = new Size(73, 15);
            lblComunidad.TabIndex = 0;
            lblComunidad.Text = "Comunidad:";
            // 
            // cboComunidad
            // 
            cboComunidad.BackColor = SystemColors.Window;
            cboComunidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboComunidad.FormattingEnabled = true;
            cboComunidad.Location = new Point(18, 32);
            cboComunidad.Margin = new Padding(3, 2, 3, 2);
            cboComunidad.Name = "cboComunidad";
            cboComunidad.Size = new Size(216, 23);
            cboComunidad.TabIndex = 1;
            cboComunidad.SelectedIndexChanged += cboComunidad_SelectedIndexChanged;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(268, 11);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(59, 15);
            lblProvincia.TabIndex = 2;
            lblProvincia.Text = "Provincia:";
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(268, 32);
            cboProvincia.Margin = new Padding(3, 2, 3, 2);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(237, 23);
            cboProvincia.TabIndex = 3;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(18, 64);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(64, 15);
            lblMunicipio.TabIndex = 4;
            lblMunicipio.Text = "Municipio:";
            // 
            // cboMunicipio
            // 
            cboMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMunicipio.FormattingEnabled = true;
            cboMunicipio.Location = new Point(18, 88);
            cboMunicipio.Margin = new Padding(3, 2, 3, 2);
            cboMunicipio.Name = "cboMunicipio";
            cboMunicipio.Size = new Size(313, 23);
            cboMunicipio.TabIndex = 5;
            cboMunicipio.SelectedIndexChanged += cboMunicipio_SelectedIndexChanged;
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.Location = new Point(359, 64);
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.Size = new Size(63, 15);
            lblPoblacion.TabIndex = 6;
            lblPoblacion.Text = "Población:";
            // 
            // cboPoblacion
            // 
            cboPoblacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPoblacion.FormattingEnabled = true;
            cboPoblacion.Location = new Point(359, 88);
            cboPoblacion.Margin = new Padding(3, 2, 3, 2);
            cboPoblacion.Name = "cboPoblacion";
            cboPoblacion.Size = new Size(302, 23);
            cboPoblacion.TabIndex = 7;
            // 
            // lblCentro
            // 
            lblCentro.AutoSize = true;
            lblCentro.Location = new Point(15, 126);
            lblCentro.Name = "lblCentro";
            lblCentro.Size = new Size(107, 15);
            lblCentro.TabIndex = 8;
            lblCentro.Text = "Nombre del centro";
            // 
            // txtCentro
            // 
            txtCentro.Location = new Point(18, 150);
            txtCentro.Margin = new Padding(3, 2, 3, 2);
            txtCentro.Name = "txtCentro";
            txtCentro.Size = new Size(316, 23);
            txtCentro.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(355, 126);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(359, 150);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(306, 23);
            txtDireccion.TabIndex = 11;
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Location = new Point(15, 186);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(81, 15);
            lblCP.TabIndex = 12;
            lblCP.Text = "Código Postal";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(534, 201);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(127, 30);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(18, 211);
            txtCodigoPostal.Margin = new Padding(3, 2, 3, 2);
            txtCodigoPostal.Mask = "00000";
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(50, 23);
            txtCodigoPostal.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 243);
            Controls.Add(txtCodigoPostal);
            Controls.Add(btnAceptar);
            Controls.Add(lblCP);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtCentro);
            Controls.Add(lblCentro);
            Controls.Add(cboPoblacion);
            Controls.Add(lblPoblacion);
            Controls.Add(cboMunicipio);
            Controls.Add(lblMunicipio);
            Controls.Add(cboProvincia);
            Controls.Add(lblProvincia);
            Controls.Add(cboComunidad);
            Controls.Add(lblComunidad);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComunidad;
        private ComboBox cboComunidad;
        private Label lblProvincia;
        private ComboBox cboProvincia;
        private Label lblMunicipio;
        private ComboBox cboMunicipio;
        private Label lblPoblacion;
        private ComboBox cboPoblacion;
        private Label lblCentro;
        private TextBox txtCentro;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblCP;
        private Button btnAceptar;
        private MaskedTextBox txtCodigoPostal;
    }
}
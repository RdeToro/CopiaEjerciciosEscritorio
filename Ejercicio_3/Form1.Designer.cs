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
            lblComunidad.Location = new Point(17, 15);
            lblComunidad.Name = "lblComunidad";
            lblComunidad.Size = new Size(89, 20);
            lblComunidad.TabIndex = 0;
            lblComunidad.Text = "Comunidad:";
            // 
            // cboComunidad
            // 
            cboComunidad.BackColor = SystemColors.Window;
            cboComunidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboComunidad.FormattingEnabled = true;
            cboComunidad.Location = new Point(21, 43);
            cboComunidad.Name = "cboComunidad";
            cboComunidad.Size = new Size(246, 28);
            cboComunidad.TabIndex = 1;
            cboComunidad.SelectedIndexChanged += cboComunidad_SelectedIndexChanged;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(306, 15);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(72, 20);
            lblProvincia.TabIndex = 2;
            lblProvincia.Text = "Provincia:";
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(306, 43);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(270, 28);
            cboProvincia.TabIndex = 3;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(21, 86);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(78, 20);
            lblMunicipio.TabIndex = 4;
            lblMunicipio.Text = "Municipio:";
            // 
            // cboMunicipio
            // 
            cboMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMunicipio.FormattingEnabled = true;
            cboMunicipio.Location = new Point(21, 118);
            cboMunicipio.Name = "cboMunicipio";
            cboMunicipio.Size = new Size(357, 28);
            cboMunicipio.TabIndex = 5;
            cboMunicipio.SelectedIndexChanged += cboMunicipio_SelectedIndexChanged;
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.Location = new Point(410, 86);
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.Size = new Size(77, 20);
            lblPoblacion.TabIndex = 6;
            lblPoblacion.Text = "Población:";
            // 
            // cboPoblacion
            // 
            cboPoblacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPoblacion.FormattingEnabled = true;
            cboPoblacion.Location = new Point(410, 118);
            cboPoblacion.Name = "cboPoblacion";
            cboPoblacion.Size = new Size(345, 28);
            cboPoblacion.TabIndex = 7;
            // 
            // lblCentro
            // 
            lblCentro.AutoSize = true;
            lblCentro.Location = new Point(17, 168);
            lblCentro.Name = "lblCentro";
            lblCentro.Size = new Size(135, 20);
            lblCentro.TabIndex = 8;
            lblCentro.Text = "Nombre del centro";
            // 
            // txtCentro
            // 
            txtCentro.Location = new Point(17, 200);
            txtCentro.Name = "txtCentro";
            txtCentro.Size = new Size(361, 27);
            txtCentro.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(406, 168);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(406, 200);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(349, 27);
            txtDireccion.TabIndex = 11;
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Location = new Point(17, 248);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(101, 20);
            lblCP.TabIndex = 12;
            lblCP.Text = "Código Postal";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(610, 268);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(145, 40);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(21, 281);
            txtCodigoPostal.Mask = "00000";
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(57, 27);
            txtCodigoPostal.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 324);
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
namespace Ejemplo_7
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            txtMail = new TextBox();
            lblMail = new Label();
            btnAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 23);
            txtNombre.TabIndex = 1;
            txtNombre.Tag = "Nombre";
            txtNombre.Validating += txtCampoObligatorio_Validating;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(15, 98);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(15, 116);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(285, 23);
            txtApellidos.TabIndex = 2;
            txtApellidos.Tag = "Apellidos";
            txtApellidos.Validating += txtCampoObligatorio_Validating;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(335, 18);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Direccion";            
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(335, 36);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(285, 23);
            txtDireccion.TabIndex = 3;
            txtDireccion.Tag = "Direccion";
            txtDireccion.Validating += txtCampoObligatorio_Validating;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(335, 116);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(285, 23);
            txtMail.TabIndex = 4;
            txtMail.Tag = "Email";
            txtMail.Validating += txtCampoObligatorio_Validating;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(335, 98);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(36, 15);
            lblMail.TabIndex = 7;
            lblMail.Text = "Email";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(547, 159);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 192);
            Controls.Add(btnAceptar);
            Controls.Add(lblMail);
            Controls.Add(txtMail);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private TextBox txtMail;
        private Label lblMail;
        private Button btnAceptar;
        private ErrorProvider errorProvider1;
    }
}
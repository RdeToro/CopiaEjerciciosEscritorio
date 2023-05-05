namespace Ejemplo_5
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
            btnGuardar = new Button();
            gboxEdicionCentro = new GroupBox();
            txtId = new TextBox();
            lblId = new Label();
            txtCentro = new TextBox();
            lblNombre = new Label();
            btnActualizar = new Button();
            gboxBorrado = new GroupBox();
            txtBorrar = new TextBox();
            lblBorradoCentro = new Label();
            btnBorrar = new Button();
            gboxEdicionCentro.SuspendLayout();
            gboxBorrado.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(35, 23);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gboxEdicionCentro
            // 
            gboxEdicionCentro.Controls.Add(txtId);
            gboxEdicionCentro.Controls.Add(lblId);
            gboxEdicionCentro.Controls.Add(txtCentro);
            gboxEdicionCentro.Controls.Add(lblNombre);
            gboxEdicionCentro.Controls.Add(btnActualizar);
            gboxEdicionCentro.Location = new Point(35, 92);
            gboxEdicionCentro.Name = "gboxEdicionCentro";
            gboxEdicionCentro.Size = new Size(726, 100);
            gboxEdicionCentro.TabIndex = 6;
            gboxEdicionCentro.TabStop = false;
            gboxEdicionCentro.Text = "Edición de Centros Pokemon";
            // 
            // txtId
            // 
            txtId.Location = new Point(493, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(493, 38);
            lblId.Name = "lblId";
            lblId.Size = new Size(75, 15);
            lblId.TabIndex = 9;
            lblId.Text = "Id del Centro";
            // 
            // txtCentro
            // 
            txtCentro.Location = new Point(30, 56);
            txtCentro.Name = "txtCentro";
            txtCentro.Size = new Size(443, 23);
            txtCentro.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(30, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(104, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre de centro";
            // 
            // btnActualizar
            // 
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(599, 56);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // gboxBorrado
            // 
            gboxBorrado.Controls.Add(btnBorrar);
            gboxBorrado.Controls.Add(txtBorrar);
            gboxBorrado.Controls.Add(lblBorradoCentro);
            gboxBorrado.Location = new Point(35, 229);
            gboxBorrado.Name = "gboxBorrado";
            gboxBorrado.Size = new Size(726, 100);
            gboxBorrado.TabIndex = 7;
            gboxBorrado.TabStop = false;
            gboxBorrado.Text = "Borrado de centros";
            // 
            // txtBorrar
            // 
            txtBorrar.Location = new Point(30, 50);
            txtBorrar.Name = "txtBorrar";
            txtBorrar.Size = new Size(100, 23);
            txtBorrar.TabIndex = 12;
            // 
            // lblBorradoCentro
            // 
            lblBorradoCentro.AutoSize = true;
            lblBorradoCentro.ForeColor = Color.Black;
            lblBorradoCentro.Location = new Point(30, 32);
            lblBorradoCentro.Name = "lblBorradoCentro";
            lblBorradoCentro.Size = new Size(75, 15);
            lblBorradoCentro.TabIndex = 11;
            lblBorradoCentro.Text = "Id del Centro";
            // 
            // btnBorrar
            // 
            btnBorrar.ForeColor = Color.Black;
            btnBorrar.Location = new Point(136, 50);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gboxBorrado);
            Controls.Add(gboxEdicionCentro);
            Controls.Add(btnGuardar);
            ForeColor = Color.Red;
            Name = "Form1";
            Text = "Form1";
            gboxEdicionCentro.ResumeLayout(false);
            gboxEdicionCentro.PerformLayout();
            gboxBorrado.ResumeLayout(false);
            gboxBorrado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private GroupBox gboxEdicionCentro;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtCentro;
        private Label lblNombre;
        private Button btnActualizar;
        private GroupBox gboxBorrado;
        private Button btnBorrar;
        private TextBox txtBorrar;
        private Label lblBorradoCentro;
    }
}
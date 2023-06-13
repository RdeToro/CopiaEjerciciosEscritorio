namespace ProyectoICPPropio
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
            lblInsertarAviso = new Button();
            gboxAvisoRecepcion = new GroupBox();
            btnVerAvisos = new Button();
            gboxAvisoRecepcion.SuspendLayout();
            SuspendLayout();
            // 
            // lblInsertarAviso
            // 
            lblInsertarAviso.Location = new Point(9, 35);
            lblInsertarAviso.Name = "lblInsertarAviso";
            lblInsertarAviso.Size = new Size(205, 23);
            lblInsertarAviso.TabIndex = 0;
            lblInsertarAviso.Text = "Insertar aviso";
            lblInsertarAviso.UseVisualStyleBackColor = true;
            lblInsertarAviso.Click += lblInsertarAviso_Click;
            // 
            // gboxAvisoRecepcion
            // 
            gboxAvisoRecepcion.Controls.Add(btnVerAvisos);
            gboxAvisoRecepcion.Controls.Add(lblInsertarAviso);
            gboxAvisoRecepcion.Location = new Point(29, 12);
            gboxAvisoRecepcion.Name = "gboxAvisoRecepcion";
            gboxAvisoRecepcion.Size = new Size(220, 121);
            gboxAvisoRecepcion.TabIndex = 1;
            gboxAvisoRecepcion.TabStop = false;
            gboxAvisoRecepcion.Text = "Aviso de Recepciones";
            // 
            // btnVerAvisos
            // 
            btnVerAvisos.Location = new Point(9, 78);
            btnVerAvisos.Name = "btnVerAvisos";
            btnVerAvisos.Size = new Size(205, 23);
            btnVerAvisos.TabIndex = 1;
            btnVerAvisos.Text = "Consultar avisos";
            btnVerAvisos.UseVisualStyleBackColor = true;
            btnVerAvisos.Click += btnVerAvisos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gboxAvisoRecepcion);
            Name = "Form1";
            Text = "Form1";
            gboxAvisoRecepcion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button lblInsertarAviso;
        private GroupBox gboxAvisoRecepcion;
        private Button btnVerAvisos;
    }
}
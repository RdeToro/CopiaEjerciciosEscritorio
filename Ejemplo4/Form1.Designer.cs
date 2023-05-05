namespace Ejemplo4
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
            btnGenerar = new Button();
            dgvDatosPersonas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPersonas).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(30, 23);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(94, 29);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvDatosPersonas
            // 
            dgvDatosPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosPersonas.Location = new Point(18, 70);
            dgvDatosPersonas.Name = "dgvDatosPersonas";
            dgvDatosPersonas.RowHeadersWidth = 51;
            dgvDatosPersonas.RowTemplate.Height = 29;
            dgvDatosPersonas.Size = new Size(770, 338);
            dgvDatosPersonas.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatosPersonas);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatosPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerar;
        private DataGridView dgvDatosPersonas;
    }
}
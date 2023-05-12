namespace Ejercicio_6
{
    partial class FormPoblacion
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
            gBoxPoblaciones = new GroupBox();
            dgvPoblaciones = new DataGridView();
            gBoxPoblaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPoblaciones).BeginInit();
            SuspendLayout();
            // 
            // gBoxPoblaciones
            // 
            gBoxPoblaciones.Controls.Add(dgvPoblaciones);
            gBoxPoblaciones.Location = new Point(12, 3);
            gBoxPoblaciones.Name = "gBoxPoblaciones";
            gBoxPoblaciones.Size = new Size(547, 221);
            gBoxPoblaciones.TabIndex = 0;
            gBoxPoblaciones.TabStop = false;
            gBoxPoblaciones.Text = "Poblaciones";
            // 
            // dgvPoblaciones
            // 
            dgvPoblaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoblaciones.Location = new Point(6, 22);
            dgvPoblaciones.Name = "dgvPoblaciones";
            dgvPoblaciones.RowTemplate.Height = 25;
            dgvPoblaciones.Size = new Size(535, 193);
            dgvPoblaciones.TabIndex = 0;
            // 
            // FormPoblacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 225);
            Controls.Add(gBoxPoblaciones);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPoblacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPoblacion";
            gBoxPoblaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPoblaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxPoblaciones;
        private DataGridView dgvPoblaciones;
    }
}
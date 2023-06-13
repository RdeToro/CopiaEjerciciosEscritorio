namespace ProyectoICPPropio
{
    partial class ConsultarAvisos
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
            dgvConsultar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultar
            // 
            dgvConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultar.Location = new Point(12, 12);
            dgvConsultar.Name = "dgvConsultar";
            dgvConsultar.RowTemplate.Height = 25;
            dgvConsultar.Size = new Size(776, 416);
            dgvConsultar.TabIndex = 0;
            // 
            // ConsultarAvisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsultar);
            Name = "ConsultarAvisos";
            Text = "ConsultarAvisos";
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultar;
    }
}
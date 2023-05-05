namespace Ejemplo4
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
            btnCargar = new Button();
            dgvPaises = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPaises).BeginInit();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(21, 18);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // dgvPaises
            // 
            dgvPaises.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaises.Location = new Point(22, 76);
            dgvPaises.Name = "dgvPaises";
            dgvPaises.RowHeadersWidth = 51;
            dgvPaises.RowTemplate.Height = 29;
            dgvPaises.Size = new Size(752, 336);
            dgvPaises.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPaises);
            Controls.Add(btnCargar);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvPaises).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargar;
        private DataGridView dgvPaises;
    }
}
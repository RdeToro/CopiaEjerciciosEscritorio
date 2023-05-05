namespace Ejemplo_4
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
            dgvPaises = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPaises).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(12, 29);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvPaises
            // 
            dgvPaises.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaises.Location = new Point(12, 68);
            dgvPaises.Name = "dgvPaises";
            dgvPaises.RowTemplate.Height = 25;
            dgvPaises.Size = new Size(776, 370);
            dgvPaises.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPaises);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPaises).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerar;
        private DataGridView dgvPaises;
    }
}
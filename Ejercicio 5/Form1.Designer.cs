namespace Ejercicio_5
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            statusStrip1 = new StatusStrip();
            ProgressBar1 = new ToolStripProgressBar();
            lblProgreso = new ToolStripStatusLabel();
            lblCarpeta = new Label();
            txtCarpeta = new TextBox();
            btnCarpeta = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnCargarFicheros = new Button();
            txtFicheros = new TextBox();
            lblFicheros = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { ProgressBar1, lblProgreso });
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            statusStrip1.Location = new Point(0, 378);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(793, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar1
            // 
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(100, 16);
            // 
            // lblProgreso
            // 
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(0, 0);
            // 
            // lblCarpeta
            // 
            lblCarpeta.AutoSize = true;
            lblCarpeta.Location = new Point(12, 9);
            lblCarpeta.Name = "lblCarpeta";
            lblCarpeta.Size = new Size(48, 15);
            lblCarpeta.TabIndex = 2;
            lblCarpeta.Text = "Carpeta";
            // 
            // txtCarpeta
            // 
            txtCarpeta.BackColor = SystemColors.Window;
            txtCarpeta.Location = new Point(12, 27);
            txtCarpeta.Name = "txtCarpeta";
            txtCarpeta.ReadOnly = true;
            txtCarpeta.Size = new Size(658, 23);
            txtCarpeta.TabIndex = 3;
            txtCarpeta.TextChanged += txtCarpeta_TextChanged;
            // 
            // btnCarpeta
            // 
            btnCarpeta.Location = new Point(676, 26);
            btnCarpeta.Name = "btnCarpeta";
            btnCarpeta.Size = new Size(24, 23);
            btnCarpeta.TabIndex = 4;
            btnCarpeta.Text = "...";
            btnCarpeta.UseVisualStyleBackColor = true;
            btnCarpeta.Click += btnCarpeta_Click;
            // 
            // btnCargarFicheros
            // 
            btnCargarFicheros.Enabled = false;
            btnCargarFicheros.Location = new Point(706, 27);
            btnCargarFicheros.Name = "btnCargarFicheros";
            btnCargarFicheros.Size = new Size(75, 23);
            btnCargarFicheros.TabIndex = 5;
            btnCargarFicheros.Text = "Cargar";
            btnCargarFicheros.UseVisualStyleBackColor = true;
            btnCargarFicheros.Click += btnCargarFicheros_Click;
            // 
            // txtFicheros
            // 
            txtFicheros.Location = new Point(12, 81);
            txtFicheros.Multiline = true;
            txtFicheros.Name = "txtFicheros";
            txtFicheros.ScrollBars = ScrollBars.Vertical;
            txtFicheros.Size = new Size(769, 294);
            txtFicheros.TabIndex = 6;
            // 
            // lblFicheros
            // 
            lblFicheros.AutoSize = true;
            lblFicheros.Location = new Point(12, 59);
            lblFicheros.Name = "lblFicheros";
            lblFicheros.Size = new Size(51, 15);
            lblFicheros.TabIndex = 8;
            lblFicheros.Text = "Ficheros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 400);
            Controls.Add(lblFicheros);
            Controls.Add(txtFicheros);
            Controls.Add(btnCargarFicheros);
            Controls.Add(btnCarpeta);
            Controls.Add(txtCarpeta);
            Controls.Add(lblCarpeta);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar ProgressBar1;
        private ToolStripStatusLabel lblProgreso;
        private Label lblCarpeta;
        private TextBox txtCarpeta;
        private Button btnCarpeta;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnCargarFicheros;
        private TextBox txtFicheros;
        private Label lblFicheros;
    }
}
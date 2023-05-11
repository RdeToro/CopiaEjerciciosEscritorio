namespace Ejemplo_8
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
            miPrimerControl1 = new MiPrimerControl();
            miPrimerControl2 = new MiPrimerControl();
            button1 = new Button();
            txtFecha1 = new TextBox();
            txtFecha2 = new TextBox();
            SuspendLayout();
            // 
            // miPrimerControl1
            // 
            miPrimerControl1.FechaFin = new DateTime(0L);
            miPrimerControl1.FechaInicio = new DateTime(0L);
            miPrimerControl1.Location = new Point(22, 18);
            miPrimerControl1.Name = "miPrimerControl1";
            miPrimerControl1.Size = new Size(432, 223);
            miPrimerControl1.TabIndex = 0;
            miPrimerControl1.Tag = "MiPrimeritoControl1";
            // 
            // miPrimerControl2
            // 
            miPrimerControl2.FechaFin = new DateTime(0L);
            miPrimerControl2.FechaInicio = new DateTime(0L);
            miPrimerControl2.Location = new Point(509, 18);
            miPrimerControl2.Name = "miPrimerControl2";
            miPrimerControl2.Size = new Size(422, 223);
            miPrimerControl2.TabIndex = 1;
            miPrimerControl2.Tag = "MiPrimeritoControl2";
            // 
            // button1
            // 
            button1.Location = new Point(22, 319);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFecha1
            // 
            txtFecha1.Location = new Point(22, 269);
            txtFecha1.Name = "txtFecha1";
            txtFecha1.Size = new Size(432, 23);
            txtFecha1.TabIndex = 3;
            // 
            // txtFecha2
            // 
            txtFecha2.Location = new Point(509, 269);
            txtFecha2.Name = "txtFecha2";
            txtFecha2.Size = new Size(422, 23);
            txtFecha2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 371);
            Controls.Add(txtFecha2);
            Controls.Add(txtFecha1);
            Controls.Add(button1);
            Controls.Add(miPrimerControl2);
            Controls.Add(miPrimerControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MiPrimerControl miPrimerControl1;
        private MiPrimerControl miPrimerControl2;
        private Button button1;
        private TextBox txtFecha1;
        private TextBox txtFecha2;
    }
}
namespace Ejemplo1b
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
            this.lblMensajeAyuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensajeAyuda
            // 
            this.lblMensajeAyuda.AutoSize = true;
            this.lblMensajeAyuda.Location = new System.Drawing.Point(23, 26);
            this.lblMensajeAyuda.Name = "lblMensajeAyuda";
            this.lblMensajeAyuda.Size = new System.Drawing.Size(199, 20);
            this.lblMensajeAyuda.TabIndex = 0;
            this.lblMensajeAyuda.Text = "Esto es un mensaje de ayuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensajeAyuda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMensajeAyuda;
    }
}
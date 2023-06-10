namespace Proyecto_ICP_desde_0
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
            gbReferencia = new GroupBox();
            SuspendLayout();
            // 
            // gbReferencia
            // 
            gbReferencia.Location = new Point(50, 27);
            gbReferencia.Name = "gbReferencia";
            gbReferencia.Size = new Size(257, 141);
            gbReferencia.TabIndex = 0;
            gbReferencia.TabStop = false;
            gbReferencia.Text = "Referencias";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 522);
            Controls.Add(gbReferencia);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbReferencia;
    }
}
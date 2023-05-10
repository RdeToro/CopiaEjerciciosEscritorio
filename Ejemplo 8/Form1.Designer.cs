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
            SuspendLayout();
            // 
            // miPrimerControl1
            // 
            miPrimerControl1.Location = new Point(24, 86);
            miPrimerControl1.Name = "miPrimerControl1";
            miPrimerControl1.Size = new Size(432, 245);
            miPrimerControl1.TabIndex = 0;
            // 
            // miPrimerControl2
            // 
            miPrimerControl2.Location = new Point(511, 86);
            miPrimerControl2.Name = "miPrimerControl2";
            miPrimerControl2.Size = new Size(422, 245);
            miPrimerControl2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(30, 363);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 456);
            Controls.Add(button1);
            Controls.Add(miPrimerControl2);
            Controls.Add(miPrimerControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MiPrimerControl miPrimerControl1;
        private MiPrimerControl miPrimerControl2;
        private Button button1;
    }
}
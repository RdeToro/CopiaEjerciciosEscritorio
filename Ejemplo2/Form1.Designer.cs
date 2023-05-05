namespace Ejemplo2
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
            lstbMiLista = new ListBox();
            statusStrip1 = new StatusStrip();
            btnVer = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lstbMiLista
            // 
            lstbMiLista.FormattingEnabled = true;
            lstbMiLista.ItemHeight = 20;
            lstbMiLista.Items.AddRange(new object[] { "Uno", "Dos", "Tres", "Cuatro ", "Cinco", "Seis", "Siete", "Domingp" });
            lstbMiLista.Location = new Point(34, 24);
            lstbMiLista.MultiColumn = true;
            lstbMiLista.Name = "lstbMiLista";
            lstbMiLista.SelectionMode = SelectionMode.MultiExtended;
            lstbMiLista.Size = new Size(467, 104);
            lstbMiLista.TabIndex = 0;
            lstbMiLista.SelectedIndexChanged += lstbMiLista_SelectedIndexChanged;
            lstbMiLista.Enter += lstbMiLista_Enter;
            lstbMiLista.Leave += lstbMiLista_Leave;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // btnVer
            // 
            btnVer.Location = new Point(67, 147);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(117, 29);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver seleccion";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(540, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnVer);
            Controls.Add(statusStrip1);
            Controls.Add(lstbMiLista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbMiLista;
        private StatusStrip statusStrip1;
        private Button btnVer;
        private TextBox textBox1;
    }
}
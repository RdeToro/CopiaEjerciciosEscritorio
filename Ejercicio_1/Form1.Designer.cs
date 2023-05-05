namespace Ejercicio_1
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
            lblId = new Label();
            txtId = new TextBox();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblModelo = new Label();
            txtModelo = new TextBox();
            btnAddCoche = new Button();
            cboCoches = new ComboBox();
            lblCoches = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(54, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 16);
            txtId.Name = "txtId";
            txtId.Size = new Size(58, 27);
            txtId.TabIndex = 1;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(26, 65);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 20);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(86, 62);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(170, 27);
            txtMarca.TabIndex = 3;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(15, 111);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(64, 20);
            lblModelo.TabIndex = 4;
            lblModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(86, 108);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(170, 27);
            txtModelo.TabIndex = 5;
            // 
            // btnAddCoche
            // 
            btnAddCoche.Location = new Point(134, 161);
            btnAddCoche.Name = "btnAddCoche";
            btnAddCoche.Size = new Size(122, 29);
            btnAddCoche.TabIndex = 6;
            btnAddCoche.Text = "Añadir coche";
            btnAddCoche.UseVisualStyleBackColor = true;
            btnAddCoche.Click += btnAddCoche_Click;
            // 
            // cboCoches
            // 
            cboCoches.FormattingEnabled = true;
            cboCoches.Location = new Point(493, 15);
            cboCoches.Name = "cboCoches";
            cboCoches.Size = new Size(213, 28);
            cboCoches.TabIndex = 7;
            // 
            // lblCoches
            // 
            lblCoches.AutoSize = true;
            lblCoches.Location = new Point(423, 19);
            lblCoches.Name = "lblCoches";
            lblCoches.Size = new Size(59, 20);
            lblCoches.TabIndex = 8;
            lblCoches.Text = "Coches:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 220);
            Controls.Add(lblCoches);
            Controls.Add(cboCoches);
            Controls.Add(btnAddCoche);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(txtMarca);
            Controls.Add(lblMarca);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblModelo;
        private TextBox txtModelo;
        private Button btnAddCoche;
        private ComboBox cboCoches;
        private Label lblCoches;
    }
}
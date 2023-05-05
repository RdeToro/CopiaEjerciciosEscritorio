namespace Ejercicio_2
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
            txtResultado = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnMenos = new Button();
            btnMas = new Button();
            btn0 = new Button();
            btnLimpiar = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            btnIgual = new Button();
            btnDecimal = new Button();
            txtAcumulado = new TextBox();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.ButtonHighlight;
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.ForeColor = Color.FromArgb(0, 0, 192);
            txtResultado.Location = new Point(22, 22);
            txtResultado.MaxLength = 20;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(294, 30);
            txtResultado.TabIndex = 1;
            txtResultado.TabStop = false;
            txtResultado.Text = "00000000000000000000";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = Color.FromArgb(192, 0, 0);
            btn1.Location = new Point(22, 103);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = Color.FromArgb(192, 0, 0);
            btn2.Location = new Point(122, 103);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = Color.FromArgb(192, 0, 0);
            btn3.Location = new Point(222, 103);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.ForeColor = Color.FromArgb(192, 0, 0);
            btn6.Location = new Point(222, 150);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 29);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = Color.FromArgb(192, 0, 0);
            btn5.Location = new Point(122, 150);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 29);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = Color.FromArgb(192, 0, 0);
            btn4.Location = new Point(22, 150);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 29);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = Color.FromArgb(192, 0, 0);
            btn9.Location = new Point(222, 199);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 29);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.ForeColor = Color.FromArgb(192, 0, 0);
            btn8.Location = new Point(122, 199);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 29);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.ForeColor = Color.FromArgb(192, 0, 0);
            btn7.Location = new Point(22, 199);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 29);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnMenos
            // 
            btnMenos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenos.ForeColor = Color.FromArgb(192, 0, 0);
            btnMenos.Location = new Point(222, 249);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(94, 29);
            btnMenos.TabIndex = 13;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMas
            // 
            btnMas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMas.ForeColor = Color.FromArgb(192, 0, 0);
            btnMas.Location = new Point(122, 249);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(94, 29);
            btnMas.TabIndex = 12;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += btnMas_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.ForeColor = Color.FromArgb(192, 0, 0);
            btn0.Location = new Point(22, 249);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 29);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(192, 0, 0);
            btnLimpiar.Location = new Point(222, 298);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "CE";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDividir.ForeColor = Color.FromArgb(192, 0, 0);
            btnDividir.Location = new Point(122, 298);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(94, 29);
            btnDividir.TabIndex = 15;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicar.ForeColor = Color.FromArgb(192, 0, 0);
            btnMultiplicar.Location = new Point(22, 298);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(94, 29);
            btnMultiplicar.TabIndex = 14;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.ForeColor = Color.FromArgb(192, 0, 0);
            btnIgual.Location = new Point(122, 346);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(194, 29);
            btnIgual.TabIndex = 18;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecimal.ForeColor = Color.FromArgb(192, 0, 0);
            btnDecimal.Location = new Point(22, 346);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(94, 29);
            btnDecimal.TabIndex = 17;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // txtAcumulado
            // 
            txtAcumulado.BorderStyle = BorderStyle.None;
            txtAcumulado.Location = new Point(22, 58);
            txtAcumulado.Name = "txtAcumulado";
            txtAcumulado.ReadOnly = true;
            txtAcumulado.Size = new Size(294, 20);
            txtAcumulado.TabIndex = 19;
            txtAcumulado.TabStop = false;
            txtAcumulado.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 399);
            Controls.Add(txtAcumulado);
            Controls.Add(btnDecimal);
            Controls.Add(btnIgual);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnMenos);
            Controls.Add(btnMas);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtResultado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            DoubleClick += Form1_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtResultado;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnMenos;
        private Button btnMas;
        private Button btn0;
        private Button btnLimpiar;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnIgual;
        private Button btnDecimal;
        private TextBox txtAcumulado;
    }
}
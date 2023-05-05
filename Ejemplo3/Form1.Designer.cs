namespace Ejemplo3
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
            chkMiControl = new CheckBox();
            chklstMiControl = new CheckedListBox();
            radioBoton1 = new RadioButton();
            radioBoton2 = new RadioButton();
            dtFecha = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            btnVerFechas = new Button();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            maskedTextBox1 = new MaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chkMiControl
            // 
            chkMiControl.AutoSize = true;
            chkMiControl.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            chkMiControl.ForeColor = Color.IndianRed;
            chkMiControl.Location = new Point(60, 33);
            chkMiControl.Margin = new Padding(4);
            chkMiControl.Name = "chkMiControl";
            chkMiControl.Size = new Size(268, 29);
            chkMiControl.TabIndex = 0;
            chkMiControl.Text = "Esto es el texto del control";
            chkMiControl.TextAlign = ContentAlignment.MiddleRight;
            chkMiControl.UseVisualStyleBackColor = true;
            chkMiControl.CheckedChanged += chkMiControl_CheckedChanged;
            // 
            // chklstMiControl
            // 
            chklstMiControl.CheckOnClick = true;
            chklstMiControl.FormattingEnabled = true;
            chklstMiControl.Items.AddRange(new object[] { "uno", "dos", "tres", "cuatro", "cinco" });
            chklstMiControl.Location = new Point(761, 21);
            chklstMiControl.Name = "chklstMiControl";
            chklstMiControl.Size = new Size(196, 166);
            chklstMiControl.TabIndex = 1;
            chklstMiControl.SelectedIndexChanged += chklstMiControl_SelectedIndexChanged;
            // 
            // radioBoton1
            // 
            radioBoton1.AutoSize = true;
            radioBoton1.Location = new Point(58, 93);
            radioBoton1.Name = "radioBoton1";
            radioBoton1.Size = new Size(154, 29);
            radioBoton1.TabIndex = 2;
            radioBoton1.TabStop = true;
            radioBoton1.Text = "Ver lista Check";
            radioBoton1.UseVisualStyleBackColor = true;
            radioBoton1.CheckedChanged += radioBoton1_CheckedChanged;
            // 
            // radioBoton2
            // 
            radioBoton2.AutoSize = true;
            radioBoton2.Location = new Point(244, 93);
            radioBoton2.Name = "radioBoton2";
            radioBoton2.Size = new Size(180, 29);
            radioBoton2.TabIndex = 3;
            radioBoton2.TabStop = true;
            radioBoton2.Text = "No ver lista Check";
            radioBoton2.UseVisualStyleBackColor = true;
            radioBoton2.CheckedChanged += radioBoton2_CheckedChanged;
            // 
            // dtFecha
            // 
            dtFecha.CalendarFont = new Font("Segoe UI", 13F, FontStyle.Italic, GraphicsUnit.Point);
            dtFecha.CalendarForeColor = SystemColors.HotTrack;
            dtFecha.CalendarMonthBackground = SystemColors.Info;
            dtFecha.CalendarTitleBackColor = Color.Red;
            dtFecha.Format = DateTimePickerFormat.Short;
            dtFecha.Location = new Point(65, 218);
            dtFecha.MaxDate = new DateTime(2023, 9, 1, 0, 0, 0, 0);
            dtFecha.MinDate = new DateTime(2023, 5, 1, 0, 0, 0, 0);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(146, 32);
            dtFecha.TabIndex = 4;
            dtFecha.Value = new DateTime(2023, 5, 1, 0, 0, 0, 0);
            dtFecha.ValueChanged += dtFecha_ValueChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(268, 219);
            monthCalendar1.MaxSelectionCount = 30;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowWeekNumbers = true;
            monthCalendar1.TabIndex = 5;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // btnVerFechas
            // 
            btnVerFechas.Location = new Point(403, 441);
            btnVerFechas.Name = "btnVerFechas";
            btnVerFechas.Size = new Size(111, 29);
            btnVerFechas.TabIndex = 6;
            btnVerFechas.Text = "Ver fechas";
            btnVerFechas.UseVisualStyleBackColor = true;
            btnVerFechas.Click += btnVerFechas_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(894, 521);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(581, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 98);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carnet de conducir";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(230, 40);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(126, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Motocicleta";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(36, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Coche";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(700, 362);
            maskedTextBox1.Mask = "000-00-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(257, 32);
            maskedTextBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(maskedTextBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrar);
            Controls.Add(btnVerFechas);
            Controls.Add(monthCalendar1);
            Controls.Add(dtFecha);
            Controls.Add(radioBoton2);
            Controls.Add(radioBoton1);
            Controls.Add(chklstMiControl);
            Controls.Add(chkMiControl);
            Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMiControl;
        private CheckedListBox chklstMiControl;
        private RadioButton radioBoton1;
        private RadioButton radioBoton2;
        private DateTimePicker dtFecha;
        private MonthCalendar monthCalendar1;
        private Button btnVerFechas;
        private Button btnCerrar;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private MaskedTextBox maskedTextBox1;
    }
}
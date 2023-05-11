namespace Ejemplo_8
{
    partial class MiPrimerControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            mcCalendario = new MonthCalendar();
            lblFechaDeInicio = new Label();
            txtFechaInicio = new TextBox();
            txtFechaFin = new TextBox();
            lblFechaFin = new Label();
            gBFechas = new GroupBox();
            gBFechas.SuspendLayout();
            SuspendLayout();
            // 
            // mcCalendario
            // 
            mcCalendario.Location = new Point(35, 28);
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 0;
            mcCalendario.DateChanged += mcCalendario_DateChanged;
            // 
            // lblFechaDeInicio
            // 
            lblFechaDeInicio.AutoSize = true;
            lblFechaDeInicio.Location = new Point(258, 52);
            lblFechaDeInicio.Name = "lblFechaDeInicio";
            lblFechaDeInicio.Size = new Size(36, 15);
            lblFechaDeInicio.TabIndex = 1;
            lblFechaDeInicio.Text = "Inicio";
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(258, 70);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(151, 23);
            txtFechaInicio.TabIndex = 2;
            txtFechaInicio.TextChanged += txtFechaInicio_TextChanged;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(258, 141);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Size = new Size(151, 23);
            txtFechaFin.TabIndex = 3;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(258, 123);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(23, 15);
            lblFechaFin.TabIndex = 4;
            lblFechaFin.Text = "Fin";
            // 
            // gBFechas
            // 
            gBFechas.Controls.Add(txtFechaInicio);
            gBFechas.Controls.Add(mcCalendario);
            gBFechas.Controls.Add(lblFechaFin);
            gBFechas.Controls.Add(lblFechaDeInicio);
            gBFechas.Controls.Add(txtFechaFin);
            gBFechas.Location = new Point(3, 3);
            gBFechas.Name = "gBFechas";
            gBFechas.Size = new Size(417, 208);
            gBFechas.TabIndex = 5;
            gBFechas.TabStop = false;
            gBFechas.Text = "Selección de Fechas";
            // 
            // MiPrimerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gBFechas);
            Name = "MiPrimerControl";
            Size = new Size(423, 244);
            gBFechas.ResumeLayout(false);
            gBFechas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar mcCalendario;
        private Label lblFechaDeInicio;
        private TextBox txtFechaInicio;
        private TextBox txtFechaFin;
        private Label lblFechaFin;
        private GroupBox gBFechas;
    }
}

namespace FormularioICP_sin_petar
{
    partial class Inicio
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
            menuStrip1 = new MenuStrip();
            productosToolStripMenuItem = new ToolStripMenuItem();
            insertarReferenciaToolStripMenuItem = new ToolStripMenuItem();
            dgvReferencias = new DataGridView();
            lblIdReferencia = new Label();
            txtIdReferencia = new TextBox();
            btnBuscar = new Button();
            btnTodos = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReferencias).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { productosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertarReferenciaToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(73, 20);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // insertarReferenciaToolStripMenuItem
            // 
            insertarReferenciaToolStripMenuItem.Name = "insertarReferenciaToolStripMenuItem";
            insertarReferenciaToolStripMenuItem.Size = new Size(168, 22);
            insertarReferenciaToolStripMenuItem.Text = "Insertar referencia";
            insertarReferenciaToolStripMenuItem.Click += insertarReferenciaToolStripMenuItem_Click;
            // 
            // dgvReferencias
            // 
            dgvReferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReferencias.Location = new Point(12, 36);
            dgvReferencias.Name = "dgvReferencias";
            dgvReferencias.RowTemplate.Height = 25;
            dgvReferencias.Size = new Size(776, 350);
            dgvReferencias.TabIndex = 1;
            // 
            // lblIdReferencia
            // 
            lblIdReferencia.AutoSize = true;
            lblIdReferencia.Location = new Point(12, 409);
            lblIdReferencia.Name = "lblIdReferencia";
            lblIdReferencia.Size = new Size(94, 15);
            lblIdReferencia.TabIndex = 2;
            lblIdReferencia.Text = "Id de referencia: ";
            // 
            // txtIdReferencia
            // 
            txtIdReferencia.Location = new Point(109, 406);
            txtIdReferencia.Name = "txtIdReferencia";
            txtIdReferencia.Size = new Size(475, 23);
            txtIdReferencia.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(590, 405);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(684, 405);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 5;
            btnTodos.Text = "Ver todo";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTodos);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdReferencia);
            Controls.Add(lblIdReferencia);
            Controls.Add(dgvReferencias);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReferencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem insertarReferenciaToolStripMenuItem;
        private DataGridView dgvReferencias;
        private Label lblIdReferencia;
        private TextBox txtIdReferencia;
        private Button btnBuscar;
        private Button btnTodos;
    }
}
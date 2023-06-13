namespace Formulario_ICP_ProgramaPropio
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
            btnInsertarAviso = new Button();
            menuStrip1 = new MenuStrip();
            avisoRecepcionesToolStripMenuItem = new ToolStripMenuItem();
            recepcionesCABToolStripMenuItem = new ToolStripMenuItem();
            recepcionesLINToolStripMenuItem = new ToolStripMenuItem();
            dgvAvisoRecepciones = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvisoRecepciones).BeginInit();
            SuspendLayout();
            // 
            // btnInsertarAviso
            // 
            btnInsertarAviso.Location = new Point(501, 395);
            btnInsertarAviso.Name = "btnInsertarAviso";
            btnInsertarAviso.Size = new Size(188, 30);
            btnInsertarAviso.TabIndex = 1;
            btnInsertarAviso.Text = "Insertar Aviso";
            btnInsertarAviso.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { avisoRecepcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // avisoRecepcionesToolStripMenuItem
            // 
            avisoRecepcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { recepcionesCABToolStripMenuItem, recepcionesLINToolStripMenuItem });
            avisoRecepcionesToolStripMenuItem.Name = "avisoRecepcionesToolStripMenuItem";
            avisoRecepcionesToolStripMenuItem.Size = new Size(117, 20);
            avisoRecepcionesToolStripMenuItem.Text = "Aviso Recepciones";
            // 
            // recepcionesCABToolStripMenuItem
            // 
            recepcionesCABToolStripMenuItem.Name = "recepcionesCABToolStripMenuItem";
            recepcionesCABToolStripMenuItem.Size = new Size(180, 22);
            recepcionesCABToolStripMenuItem.Text = "Recepciones CAB";
            recepcionesCABToolStripMenuItem.Click += recepcionesCABToolStripMenuItem_Click;
            // 
            // recepcionesLINToolStripMenuItem
            // 
            recepcionesLINToolStripMenuItem.Name = "recepcionesLINToolStripMenuItem";
            recepcionesLINToolStripMenuItem.Size = new Size(180, 22);
            recepcionesLINToolStripMenuItem.Text = "Recepciones LIN";
            // 
            // dgvAvisoRecepciones
            // 
            dgvAvisoRecepciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvisoRecepciones.Location = new Point(111, 27);
            dgvAvisoRecepciones.Name = "dgvAvisoRecepciones";
            dgvAvisoRecepciones.RowTemplate.Height = 25;
            dgvAvisoRecepciones.Size = new Size(677, 362);
            dgvAvisoRecepciones.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 432);
            Controls.Add(dgvAvisoRecepciones);
            Controls.Add(btnInsertarAviso);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvisoRecepciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnInsertarAviso;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem avisoRecepcionesToolStripMenuItem;
        private ToolStripMenuItem recepcionesCABToolStripMenuItem;
        private ToolStripMenuItem recepcionesLINToolStripMenuItem;
        private DataGridView dgvAvisoRecepciones;
    }
}
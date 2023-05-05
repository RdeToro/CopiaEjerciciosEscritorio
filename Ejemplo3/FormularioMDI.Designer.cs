namespace Ejemplo3
{
    partial class FormularioMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            formulariosToolStripMenuItem = new ToolStripMenuItem();
            mnuFormulario1 = new ToolStripMenuItem();
            mnuFormulario2 = new ToolStripMenuItem();
            formulario3ToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            formulario4ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { formulariosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // formulariosToolStripMenuItem
            // 
            formulariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuFormulario1, mnuFormulario2, formulario3ToolStripMenuItem, formulario4ToolStripMenuItem });
            formulariosToolStripMenuItem.MergeIndex = 0;
            formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            formulariosToolStripMenuItem.Size = new Size(101, 24);
            formulariosToolStripMenuItem.Text = "Formularios";
            // 
            // mnuFormulario1
            // 
            mnuFormulario1.Name = "mnuFormulario1";
            mnuFormulario1.Size = new Size(224, 26);
            mnuFormulario1.Text = "Formulario 1";
            mnuFormulario1.Click += mnuFormulario1_Click;
            // 
            // mnuFormulario2
            // 
            mnuFormulario2.Name = "mnuFormulario2";
            mnuFormulario2.Size = new Size(224, 26);
            mnuFormulario2.Text = "Formulario2";
            mnuFormulario2.Click += mnuFormulario2_Click;
            // 
            // formulario3ToolStripMenuItem
            // 
            formulario3ToolStripMenuItem.Name = "formulario3ToolStripMenuItem";
            formulario3ToolStripMenuItem.Size = new Size(224, 26);
            formulario3ToolStripMenuItem.Text = "Formulario 3";
            formulario3ToolStripMenuItem.Click += formulario3ToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.MergeIndex = 2;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // formulario4ToolStripMenuItem
            // 
            formulario4ToolStripMenuItem.Name = "formulario4ToolStripMenuItem";
            formulario4ToolStripMenuItem.Size = new Size(224, 26);
            formulario4ToolStripMenuItem.Text = "Formulario 4";
            formulario4ToolStripMenuItem.Click += formulario4ToolStripMenuItem_Click;
            // 
            // FormularioMDI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormularioMDI";
            Text = "FormularioMDI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formulariosToolStripMenuItem;
        private ToolStripMenuItem mnuFormulario1;
        private ToolStripMenuItem mnuFormulario2;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem formulario3ToolStripMenuItem;
        private ToolStripMenuItem formulario4ToolStripMenuItem;
    }
}
namespace Ejemplo3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            abrirVentanaToolStripMenuItem = new ToolStripMenuItem();
            nuevaVentanaToolStripMenuItem = new ToolStripMenuItem();
            editarTextoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblMensaje = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnVerFormulario = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(484, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 232);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { abrirVentanaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // abrirVentanaToolStripMenuItem
            // 
            abrirVentanaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaVentanaToolStripMenuItem, editarTextoToolStripMenuItem });
            abrirVentanaToolStripMenuItem.MergeAction = MergeAction.Insert;
            abrirVentanaToolStripMenuItem.MergeIndex = 1;
            abrirVentanaToolStripMenuItem.Name = "abrirVentanaToolStripMenuItem";
            abrirVentanaToolStripMenuItem.Size = new Size(113, 24);
            abrirVentanaToolStripMenuItem.Text = "Abrir Ventana";
            // 
            // nuevaVentanaToolStripMenuItem
            // 
            nuevaVentanaToolStripMenuItem.Name = "nuevaVentanaToolStripMenuItem";
            nuevaVentanaToolStripMenuItem.Size = new Size(224, 26);
            nuevaVentanaToolStripMenuItem.Text = "Nueva ventana";
            nuevaVentanaToolStripMenuItem.Click += nuevaVentanaToolStripMenuItem_Click;
            // 
            // editarTextoToolStripMenuItem
            // 
            editarTextoToolStripMenuItem.Name = "editarTextoToolStripMenuItem";
            editarTextoToolStripMenuItem.Size = new Size(224, 26);
            editarTextoToolStripMenuItem.Text = "Editar Texto";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.MergeAction = MergeAction.MatchOnly;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblMensaje });
            statusStrip1.Location = new Point(0, 566);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblMensaje
            // 
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(151, 20);
            lblMensaje.Text = "toolStripStatusLabel1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnVerFormulario);
            groupBox1.Location = new Point(36, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 218);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // btnVerFormulario
            // 
            btnVerFormulario.Location = new Point(222, 147);
            btnVerFormulario.Name = "btnVerFormulario";
            btnVerFormulario.Size = new Size(131, 29);
            btnVerFormulario.TabIndex = 0;
            btnVerFormulario.Text = "Ver formulario";
            btnVerFormulario.UseVisualStyleBackColor = true;
            btnVerFormulario.Click += btnVerFormulario_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 592);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem abrirVentanaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem nuevaVentanaToolStripMenuItem;
        private ToolStripMenuItem editarTextoToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblMensaje;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnVerFormulario;
    }
}
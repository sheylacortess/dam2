namespace Reloj
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
            menuStrip1 = new MenuStrip();
            paisToolStripMenuItem = new ToolStripMenuItem();
            añadirToolStripMenuItem = new ToolStripMenuItem();
            borrarToolStripMenuItem = new ToolStripMenuItem();
            txtHoraActual = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { paisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // paisToolStripMenuItem
            // 
            paisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { añadirToolStripMenuItem, borrarToolStripMenuItem });
            paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            paisToolStripMenuItem.Size = new Size(40, 20);
            paisToolStripMenuItem.Text = "Pais";
            // 
            // añadirToolStripMenuItem
            // 
            añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            añadirToolStripMenuItem.Size = new Size(180, 22);
            añadirToolStripMenuItem.Text = "Añadir";
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(180, 22);
            borrarToolStripMenuItem.Text = "Borrar";
            // 
            // txtHoraActual
            // 
            txtHoraActual.Location = new Point(62, 50);
            txtHoraActual.Name = "txtHoraActual";
            txtHoraActual.Size = new Size(167, 23);
            txtHoraActual.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtHoraActual);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem paisToolStripMenuItem;
        private ToolStripMenuItem añadirToolStripMenuItem;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private TextBox txtHoraActual;
    }
}

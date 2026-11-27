namespace Juego
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
            components = new System.ComponentModel.Container();
            pcbBola = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pcbPaleta = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbBola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPaleta).BeginInit();
            SuspendLayout();
            // 
            // pcbBola
            // 
            pcbBola.Image = Properties.Resources.estrella;
            pcbBola.Location = new Point(361, 133);
            pcbBola.Name = "pcbBola";
            pcbBola.Size = new Size(54, 60);
            pcbBola.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBola.TabIndex = 0;
            pcbBola.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // pcbPaleta
            // 
            pcbPaleta.Image = Properties.Resources.casa;
            pcbPaleta.Location = new Point(279, 294);
            pcbPaleta.Name = "pcbPaleta";
            pcbPaleta.Size = new Size(279, 44);
            pcbPaleta.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPaleta.TabIndex = 1;
            pcbPaleta.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pcbPaleta);
            Controls.Add(pcbBola);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pcbBola).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPaleta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbBola;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pcbPaleta;
    }
}

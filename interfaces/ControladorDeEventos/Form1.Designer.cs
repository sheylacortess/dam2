namespace ControladorDeEventos
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
            lstTitulos = new ListBox();
            lstActores = new ListBox();
            lstDirectores = new ListBox();
            SuspendLayout();
            // 
            // lstTitulos
            // 
            lstTitulos.FormattingEnabled = true;
            lstTitulos.ItemHeight = 15;
            lstTitulos.Location = new Point(283, 71);
            lstTitulos.Name = "lstTitulos";
            lstTitulos.Size = new Size(401, 79);
            lstTitulos.TabIndex = 0;
            // 
            // lstActores
            // 
            lstActores.FormattingEnabled = true;
            lstActores.ItemHeight = 15;
            lstActores.Location = new Point(283, 176);
            lstActores.Name = "lstActores";
            lstActores.Size = new Size(401, 79);
            lstActores.TabIndex = 1;
            // 
            // lstDirectores
            // 
            lstDirectores.FormattingEnabled = true;
            lstDirectores.ItemHeight = 15;
            lstDirectores.Location = new Point(283, 278);
            lstDirectores.Name = "lstDirectores";
            lstDirectores.Size = new Size(401, 79);
            lstDirectores.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDirectores);
            Controls.Add(lstActores);
            Controls.Add(lstTitulos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstTitulos;
        private ListBox lstActores;
        private ListBox lstDirectores;
    }
}

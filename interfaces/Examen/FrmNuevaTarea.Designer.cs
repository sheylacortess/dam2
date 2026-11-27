namespace Examen
{
    partial class FrmNuevaTarea
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
            btnGuardar = new Button();
            txtEstado = new TextBox();
            txtFechaLimite = new TextBox();
            txtAsigando = new TextBox();
            txtTarea = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(154, 219);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(154, 177);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 2;
            // 
            // txtFechaLimite
            // 
            txtFechaLimite.Location = new Point(154, 148);
            txtFechaLimite.Name = "txtFechaLimite";
            txtFechaLimite.Size = new Size(100, 23);
            txtFechaLimite.TabIndex = 3;
            // 
            // txtAsigando
            // 
            txtAsigando.Location = new Point(154, 109);
            txtAsigando.Name = "txtAsigando";
            txtAsigando.Size = new Size(100, 23);
            txtAsigando.TabIndex = 4;
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(154, 80);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(100, 23);
            txtTarea.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 80);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "Tarea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 112);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 7;
            label2.Text = "Asignado a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 151);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha Limite";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 185);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 9;
            label4.Text = "Estado";
            // 
            // FrmNuevaTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTarea);
            Controls.Add(txtAsigando);
            Controls.Add(txtFechaLimite);
            Controls.Add(txtEstado);
            Controls.Add(btnGuardar);
            Name = "FrmNuevaTarea";
            Text = "NuevaTarea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtEstado;
        private TextBox txtFechaLimite;
        private TextBox txtAsigando;
        private TextBox txtTarea;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
namespace Examen
{
    partial class FrmModificarTarea
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTarea = new TextBox();
            txtAsigando = new TextBox();
            txtFechaLimite = new TextBox();
            txtEstado = new TextBox();
            btnGuardar = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 209);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 18;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 175);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 17;
            label3.Text = "Fecha Limite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 136);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 16;
            label2.Text = "Asignado a";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 104);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 15;
            label1.Text = "Tarea";
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(162, 104);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(100, 23);
            txtTarea.TabIndex = 14;
            // 
            // txtAsigando
            // 
            txtAsigando.Location = new Point(162, 133);
            txtAsigando.Name = "txtAsigando";
            txtAsigando.Size = new Size(100, 23);
            txtAsigando.TabIndex = 13;
            // 
            // txtFechaLimite
            // 
            txtFechaLimite.Location = new Point(162, 172);
            txtFechaLimite.Name = "txtFechaLimite";
            txtFechaLimite.Size = new Size(100, 23);
            txtFechaLimite.TabIndex = 12;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(162, 201);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(162, 243);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(59, 44);
            label5.Name = "label5";
            label5.Size = new Size(177, 32);
            label5.TabIndex = 19;
            label5.Text = "Modificar Tarea";
            // 
            // FrmModificarTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTarea);
            Controls.Add(txtAsigando);
            Controls.Add(txtFechaLimite);
            Controls.Add(txtEstado);
            Controls.Add(btnGuardar);
            Name = "FrmModificarTarea";
            Text = "FrmModificarTarea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTarea;
        private TextBox txtAsigando;
        private TextBox txtFechaLimite;
        private TextBox txtEstado;
        private Button btnGuardar;
        private Label label5;
    }
}
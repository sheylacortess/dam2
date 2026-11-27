namespace Examen
{
    partial class FrmGestioProyectos
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
            treeViewProyectos = new TreeView();
            listViewTareas = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnNuevoProyecto = new Button();
            btnNuevaTarea = new Button();
            btnModificarTarea = new Button();
            btnGestionarProyecto = new Button();
            SuspendLayout();
            // 
            // treeViewProyectos
            // 
            treeViewProyectos.Location = new Point(43, 49);
            treeViewProyectos.Name = "treeViewProyectos";
            treeViewProyectos.Size = new Size(179, 375);
            treeViewProyectos.TabIndex = 0;
            treeViewProyectos.Tag = "";
            treeViewProyectos.AfterSelect += treeViewProyectos_AfterSelect;
            // 
            // listViewTareas
            // 
            listViewTareas.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewTareas.FullRowSelect = true;
            listViewTareas.Location = new Point(237, 49);
            listViewTareas.Name = "listViewTareas";
            listViewTareas.Size = new Size(523, 282);
            listViewTareas.TabIndex = 1;
            listViewTareas.UseCompatibleStateImageBehavior = false;
            listViewTareas.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = " ";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tarea";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Asignado a";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha Limite";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Estado";
            columnHeader4.Width = 120;
            // 
            // btnNuevoProyecto
            // 
            btnNuevoProyecto.Location = new Point(249, 361);
            btnNuevoProyecto.Name = "btnNuevoProyecto";
            btnNuevoProyecto.Size = new Size(128, 47);
            btnNuevoProyecto.TabIndex = 2;
            btnNuevoProyecto.Text = "Nuevo Proyecto";
            btnNuevoProyecto.UseVisualStyleBackColor = true;
            btnNuevoProyecto.Click += btnNuevoProyecto_Click;
            // 
            // btnNuevaTarea
            // 
            btnNuevaTarea.Location = new Point(383, 361);
            btnNuevaTarea.Name = "btnNuevaTarea";
            btnNuevaTarea.Size = new Size(128, 47);
            btnNuevaTarea.TabIndex = 3;
            btnNuevaTarea.Text = "Nueva Tarea";
            btnNuevaTarea.UseVisualStyleBackColor = true;
            btnNuevaTarea.Click += btnNuevaTarea_Click;
            // 
            // btnModificarTarea
            // 
            btnModificarTarea.Location = new Point(517, 361);
            btnModificarTarea.Name = "btnModificarTarea";
            btnModificarTarea.Size = new Size(128, 47);
            btnModificarTarea.TabIndex = 4;
            btnModificarTarea.Text = "Modificar Tarea";
            btnModificarTarea.UseVisualStyleBackColor = true;
            btnModificarTarea.Click += btnModificarTarea_Click;
            // 
            // btnGestionarProyecto
            // 
            btnGestionarProyecto.Location = new Point(651, 361);
            btnGestionarProyecto.Name = "btnGestionarProyecto";
            btnGestionarProyecto.Size = new Size(128, 47);
            btnGestionarProyecto.TabIndex = 5;
            btnGestionarProyecto.Text = "Guardar Fichero";
            btnGestionarProyecto.UseVisualStyleBackColor = true;
            // 
            // FrmGestioProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestionarProyecto);
            Controls.Add(btnModificarTarea);
            Controls.Add(btnNuevaTarea);
            Controls.Add(btnNuevoProyecto);
            Controls.Add(listViewTareas);
            Controls.Add(treeViewProyectos);
            Name = "FrmGestioProyectos";
            Text = "Gestion de Proyectos";
            Load += FrmGestioProyectos_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeViewProyectos;
        private ListView listViewTareas;
        private Button btnNuevoProyecto;
        private Button btnNuevaTarea;
        private Button btnModificarTarea;
        private Button btnGestionarProyecto;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
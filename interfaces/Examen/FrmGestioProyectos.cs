using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class FrmGestioProyectos : Form
    {
        public FrmGestioProyectos()
        {
            InitializeComponent();
        }

        public void CargarTreeView()
        {
            treeViewProyectos.Nodes.Clear();
            foreach (Proyecto p in Program.ListaProyectos)
            {
                TreeNode nodoProyecto = new TreeNode();
                nodoProyecto.Tag = p;

                foreach (Tarea t in p.Tareas)
                {
                    TreeNode nodoTarea = new TreeNode();
                    nodoTarea.Tag = t;
                    nodoProyecto.Nodes.Add(nodoTarea);
                }
                treeViewProyectos.Nodes.Add(nodoProyecto);
            }
            treeViewProyectos.ExpandAll();
        }

        private void treeViewProyectos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewTareas.Items.Clear();
            // compruebo si el nodo es un proyecto
            if (e.Node.Tag is Proyecto p)
            {
                foreach (Tarea t in p.Tareas)
                {
                    ListViewItem item = new ListViewItem(t.Nombre);
                    item.SubItems.Add(t.Asignado);
                    item.SubItems.Add(t.Fecha);
                    item.SubItems.Add(t.Estado);
                    item.Tag = t; // guardamso la tarea
                }
            }
        }

        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            FrmNuevoProyecto frm = new FrmNuevoProyecto();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarTreeView();
            }
        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            FrmNuevaTarea frm = new FrmNuevaTarea();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarTreeView();
            }
        }

        private void btnModificarTarea_Click(object sender, EventArgs e)
        {
            //miro a ver si hay alguna fila seleccionada
            if (listViewTareas.SelectedItems.Count > 0 && treeViewProyectos.SelectedNode.Tag is Proyecto p)
            {
                //guardoi en la nueva tarea el del tag
                Tarea t = (Tarea)listViewTareas.SelectedItems[0].Tag;
                FrmModificarTarea frm = new FrmModificarTarea(t);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarTreeView();
                    treeViewProyectos_AfterSelect(sender, new TreeViewEventArgs(treeViewProyectos.SelectedNode));

                }
            }
        }

        private void FrmGestioProyectos_Load(object sender, EventArgs e)
        {
            CargarTreeView();
        }
    }
}

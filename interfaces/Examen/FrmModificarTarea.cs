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
    public partial class FrmModificarTarea : Form
    {
        private Tarea tareaModificar;
        public FrmModificarTarea(Tarea t)
        {
            InitializeComponent();
            tareaModificar = t;
            txtTarea.Text = t.Nombre;
            txtAsigando.Text = t.Asignado;
            txtFechaLimite.Text = t.Fecha;
            txtEstado.Text = t.Estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tareaModificar.Nombre = txtTarea.Text;
            tareaModificar.Asignado = txtAsigando.Text;
            tareaModificar.Fecha = txtFechaLimite.Text;
            tareaModificar.Estado = txtEstado.Text;

            DialogResult = DialogResult.OK;
            Close();

        }
    }
}

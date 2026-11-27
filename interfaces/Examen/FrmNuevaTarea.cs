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
    public partial class FrmNuevaTarea : Form
    {
        public FrmNuevaTarea()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Tarea TareaCreada = new Tarea(txtTarea.Text, txtAsigando.Text, txtFechaLimite.Text, txtEstado.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

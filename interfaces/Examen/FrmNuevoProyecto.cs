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
    public partial class FrmNuevoProyecto : Form
    {
        public FrmNuevoProyecto()
        {
            InitializeComponent();
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text)){
                Program.ListaProyectos.Add(new Proyecto(txtNombre.Text.Trim()));
                DialogResult = DialogResult.OK;
                Close();
            }else
            {
                MessageBox.Show("Introduce el nombre del proeyecto.");
            }
        }
    }
}

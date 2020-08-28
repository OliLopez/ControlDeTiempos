using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeTiempos
{
    public partial class Ventana_Modificar : Form
    {
        Clase_ABM mostrar = new Clase_ABM();
        string mempleado = "/";
        string mejercicio = "/";
        public Ventana_Modificar()
        {
            InitializeComponent();
        }
        private void picModificar_MouseLeave(object sender, EventArgs e)
        {
            picModificar.BackColor = Color.Transparent;
        }

        private void picModificar_MouseMove(object sender, MouseEventArgs e)
        {
            picModificar.BackColor = Color.Goldenrod;
        }

        private void picModificar_Click_1(object sender, EventArgs e)
        {
            mempleado = cmbModificar.Text;
            mejercicio = cmbAñoModificar.Text;
            mostrar.Modiempleado(dgvModificar, mempleado, mejercicio);
        }

        private void Ventana_Modificar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controlTiemposDataSetempleado.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.controlTiemposDataSetempleado.empleado);
            cmbModificar.Text = "";
        }
    }
}

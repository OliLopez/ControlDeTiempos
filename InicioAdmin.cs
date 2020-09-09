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
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
        }
        //diseño
        private void picBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            picBuscar.BackColor = Color.Goldenrod;
        }

        private void picBuscar_MouseLeave(object sender, EventArgs e)
        {
            picBuscar.BackColor = Color.DarkGray;
        }

        private void picAB_MouseMove(object sender, MouseEventArgs e)
        {
            picAB.BackColor = Color.Goldenrod;
        }

        private void picAB_MouseLeave(object sender, EventArgs e)
        {
            picAB.BackColor = Color.DarkGray;
        }
        private void picformModi_MouseMove(object sender, MouseEventArgs e)
        {
            picformModi.BackColor = Color.Goldenrod;
        }

        private void picformModi_MouseLeave(object sender, EventArgs e)
        {
            picformModi.BackColor = Color.DarkGray;
        }
        //fin diseño
        private void picAB_Click(object sender, EventArgs e)
        {
            new AltaBajaForm().ShowDialog();
        }

        private void picformModi_Click(object sender, EventArgs e)
        {
            new Ventana_Modificar().ShowDialog();
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            new CalculadorHrs().ShowDialog();
        }
        //CERRAR APLICACION
        private void InicioAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

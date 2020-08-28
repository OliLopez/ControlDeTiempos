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
    public partial class AltaBajaForm : Form
    {
        Clase_ABM mostrar = new Clase_ABM();
        string rol = "Usuario";

        public AltaBajaForm()
        {
            InitializeComponent();
        }
        private void picAltas_MouseMove(object sender, MouseEventArgs e)
        {
            picAltas.BackColor = Color.Goldenrod;
        }
        private void picAltas_MouseLeave(object sender, EventArgs e)
        {
            picAltas.BackColor = Color.Transparent;
        }
        private void picBajas_MouseMove(object sender, MouseEventArgs e)
        {
            picBajas.BackColor = Color.Goldenrod;
        }
        private void picBajas_MouseLeave(object sender, EventArgs e)
        {
            picBajas.BackColor = Color.Transparent;
        }
        private void cmbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEliminar.SelectedIndex==0)//empleados
            {
                //desplegar empleados dgvResult
                mostrar.empleados(dgvResult);
            }
            if (cmbEliminar.SelectedIndex==1)//empresas
            {
                mostrar.empresas(dgvResult);
            }
        }
        private void picAltas_Click(object sender, EventArgs e)
        {
            if(!(txtUsuario.Text=="")&&!(txtNombre.Text=="")&&!(txtContra.Text==""))
            {
                errorProviderA.SetError(panel2, "");
                mostrar.nuevoUsuario(txtNombre.Text, txtUsuario.Text, txtContra.Text, rol);
                mostrar.cmbAdmin(txtNombre.Text);
                mostrar.login(dgvResult);
                txtUsuario.Text = "";
                txtNombre.Text = "";
                txtContra.Text = "";
            }
            if (!(txtUsuario.Text == "") && (txtNombre.Text == "") && (txtContra.Text == "") || (txtUsuario.Text == "") && !(txtNombre.Text == "") && (txtContra.Text == "") || (txtUsuario.Text == "") && (txtNombre.Text == "") && !(txtContra.Text == ""))
            {
                errorProviderA.SetError(panel2, "Ingresar los datos solicitados");
            }
            if (!(txtAño.Text == "") && txtAño.Text.All(Char.IsNumber))
            {
                mostrar.nuevoAño(txtAño.Text);
                txtAño.Text = "";
                errorProviderA.SetError(txtAño, "");
            }
            if(!(txtAño.Text.All(Char.IsNumber)))
            {
                errorProviderA.SetError(txtAño, "Ingresar año valido");
            }
            if (!(txtEmpresa.Text == ""))
            {
                mostrar.nuevaEmpresa(txtEmpresa.Text);
                mostrar.cmbEmpresa(txtEmpresa.Text);
                mostrar.empresas(dgvResult);
                txtEmpresa.Text = "";
            }
            if (!(txtConcepto.Text == ""))
            {
                mostrar.nuevoConcepto(txtConcepto.Text);
                txtConcepto.Text ="";
            }
            else
            {
                mostrar.login(dgvResult);
            }
        }
    }
}

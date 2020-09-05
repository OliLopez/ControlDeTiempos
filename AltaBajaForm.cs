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
        string mensaje;
        Boolean encendidoempresa;
        Boolean encendidoempleado;
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
            if (cmbEliminar.SelectedIndex==0)//empleados
            {
                encendidoempleado = true;
                encendidoempresa = false;
                //desplegar empleados dgvResult
                mostrar.empleados(dgvResult);
            }
            if (cmbEliminar.SelectedIndex==1)//empresas
            {
                encendidoempleado = false;
                encendidoempresa = true;
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
                mostrar.nuevoAño(Convert.ToInt32( txtAño.Text));
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

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mensaje = dgvResult.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            lblLeyendaBaja.Text="";
        }
        private void picBajas_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar "+mensaje+" del registro?", "Confirmacion", buttons);

            if (dialogResult == DialogResult.Yes)
            {
                if(encendidoempleado==true)
                {
                    mostrar.empleadoBaja(mensaje);
                    mostrar.cmbempl_Baja(mensaje);
                    //desplegar empleados dgvResult
                    mostrar.empleados(dgvResult);
                }
                if (encendidoempresa == true)
                {
                    mostrar.empresaBaja(mensaje);
                    mostrar.cmbempr_Baja(mensaje);
                    mostrar.empresas(dgvResult);
                }
            }

        }

        private void AltaBajaForm_Load(object sender, EventArgs e)
        {
            lblLeyendaBaja.Text = "No se ha seleecionado \n ningun elemento";
        }
    }
}

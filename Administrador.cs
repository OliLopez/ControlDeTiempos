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
    public partial class Administrador : Form
    {
        string[] array_empresaAdmin;
        string[] array_añoAdmin;
        string[] array_areaAdmin;
        string[] array_empleado = {"Julio","Socorro"};
        public Administrador()
        {
            InitializeComponent();
            //el archivo txt se pasa a string
            string slistado_empresasAdmin = Properties.Resources.empresa.ToString();
            string slistado_añoAdmin = Properties.Resources.año.ToString();
            string slistado_areaAdmin = Properties.Resources.area.ToString();
            //arreglo empresa se inicializa dentro de este constructor leyendo los datos del archivo txt
            //metodo Split genera un nuevo arreglo en el cual el separador sea los caracteres:"\r\n"
            array_empresaAdmin = slistado_empresasAdmin.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            array_añoAdmin = slistado_añoAdmin.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            array_areaAdmin = slistado_areaAdmin.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            desplegarEmpresas();
            desplegarAños();
            desplegarAreas();
            desplegarEmpleados();
        }
        //Metodos para el Llenado de los combos
        void desplegarAreas()
        {
            for (int i = 0; i < array_areaAdmin.Length; i++)
            {
                cmbArea.Items.Add(array_areaAdmin[i]);

            }
        }
        void desplegarEmpresas()
        {
            for (int i = 0; i < array_empresaAdmin.Length; i++)
            {
                cmbEmpresa.Items.Add(array_empresaAdmin[i]);

            }
        }
        void desplegarAños()
        {
            for (int i = 0; i < array_añoAdmin.Length; i++)
            {
                cmbAño.Items.Add(array_añoAdmin[i]);

            }
        }
        void desplegarEmpleados()
        {
            for (int i = 0; i < array_empleado.Length; i++)
            {
                cmbEmpleado.Items.Add(array_empleado[i]);
            }
        }
        //Inicio Diseño 
        private void btnReporte_MouseMove(object sender, MouseEventArgs e)
        {
            btnReporte.BackColor = Color.Goldenrod;
            btnReporte.ForeColor = Color.Black;
        }

        private void btnReporte_MouseLeave(object sender, EventArgs e)
        {
            btnReporte.BackColor = Color.DodgerBlue;
            btnReporte.ForeColor = Color.White;
        }

        private void comboAdminEmpresa_MouseMove(object sender, MouseEventArgs e)
        {
            lblEmpresa.BackColor = Color.Goldenrod;
            lblaño.BackColor = Color.Transparent;
            lblempleado.BackColor = Color.Transparent;
            lblArea.BackColor = Color.Transparent;
        }

        private void comboAdminEmpresa_MouseLeave(object sender, EventArgs e)
        {
            lblEmpresa.BackColor = Color.Transparent;
        }

        private void comboAdminAño_MouseLeave(object sender, EventArgs e)
        {
            lblaño.BackColor = Color.Transparent;
        }

        private void comboAdminAño_MouseMove(object sender, MouseEventArgs e)
        {
            lblaño.BackColor = Color.Goldenrod;
            lblEmpresa.BackColor = Color.Transparent;
            lblempleado.BackColor = Color.Transparent;
            lblArea.BackColor = Color.Transparent;
        }

        private void comboEmpleado_MouseLeave(object sender, EventArgs e)
        {
            lblempleado.BackColor = Color.Transparent;
        }

        private void comboEmpleado_MouseMove(object sender, MouseEventArgs e)
        {
            lblempleado.BackColor = Color.Goldenrod;
            lblEmpresa.BackColor = Color.Transparent;
            lblaño.BackColor = Color.Transparent;
            lblArea.BackColor = Color.Transparent;
        }
        private void cmbArea_MouseLeave(object sender, EventArgs e)
        {
            lblArea.BackColor = Color.Transparent;
        }

        private void cmbArea_MouseMove(object sender, MouseEventArgs e)
        {
            lblArea.BackColor = Color.Goldenrod;
            lblEmpresa.BackColor = Color.Transparent;
            lblaño.BackColor = Color.Transparent;
        }

        //Fin Diseño
        //CERRAR APLICACION
        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //INICIO DE VALIDACIONES DE LOS CAMPOS COMBOBOX
        int validacionAdmin()
        {
            //todas las relaciones implican que se debe escoger un año en especifico
            if (cmbAño.SelectedIndex<=-1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
            //FIN VALIDACIONES
            //DESAROLLO DE BOTONES
            private void btnReporte_Click(object sender, EventArgs e)
        {
            switch (validacionAdmin())
            {
                case 0:
                    {
                        //no hay ningun error
                        errorProviderAdmin.SetError(panel1, "");
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("validaciones basicas completas ", "Datos correctos", buttons);
                        using (ReporteAdmin ventanaReporteGeneral = new ReporteAdmin())
                            ventanaReporteGeneral.ShowDialog();
                        break;
                        //MOSTRAR EL REPORTE SOLICITADO:

                    }
                case 1:
                    {
                        errorProviderAdmin.SetError(cmbAño, "seleccione un año");
                        cmbAño.Focus();
                        break;
                    }
            } 
        }

        //FIN DESAROLLO DE BOTONES
    }
}

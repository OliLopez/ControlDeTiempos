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
            //en opciones del split, si se ve una linea vacia se elimine
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
        void desplegarEmpresas()
        {
            for (int i = 0; i < array_empresaAdmin.Length; i++)
            {
                comboAdminEmpresa.Items.Add(array_empresaAdmin[i]);

            }
        }
        void desplegarAños()
        {
            for (int i = 0; i < array_añoAdmin.Length; i++)
            {
                comboAdminAño.Items.Add(array_añoAdmin[i]);

            }
        }
        void desplegarAreas()
        {
            for (int i = 0; i < array_areaAdmin.Length; i++)
            {
                comboAdminArea.Items.Add(array_areaAdmin[i]);
            }
        }

        void desplegarEmpleados()
        {
            for (int i = 0; i < array_empleado.Length; i++)
            {
                comboEmpleado.Items.Add(array_empleado[i]);
            }
        }
        //Inicio Diseño boton
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
        //Fin Diseño boton
    }
}

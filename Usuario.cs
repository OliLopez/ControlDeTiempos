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
    public partial class Usuario : Form
    {

        string[] array_empresa;
        string[] array_año;
        string[] array_area;
        string[] array_concepto;
        public Usuario(string nombre)
        {
            InitializeComponent();
            lbBienvenido.Text = "Bienvenido, "+nombre;
            //el archivo txt se pasa a string
            string slistado_empresas = Properties.Resources.empresa.ToString();
            string slistado_año = Properties.Resources.año.ToString();
            string slistado_area = Properties.Resources.area.ToString();
            string slistado_concepto = Properties.Resources.concepto.ToString();
            //arreglo empresa se inicializa dentro de este constructor leyendo los datos del archivo txt
            //metodo Split genera un nuevo arreglo en el cual el separador sea los caracteres:"\r\n"
            //en opciones del split, si se ve una linea vacia se elimine
            array_empresa = slistado_empresas.Split(new[] {"\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            array_año = slistado_año.Split(new[] {"\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            array_area = slistado_area.Split(new[] {"\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            array_concepto = slistado_concepto.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            desplegarEmpresas();
            desplegarAños();
            desplegarAreas();
            desplegarConceptos();
        }
    
        //Metodos para el Llenado de los combos
        void desplegarEmpresas()
        {
            for(int i=0;i<array_empresa.Length;i++)
            {
                comboEmpresa.Items.Add(array_empresa[i]);

            }
        }
        void desplegarAños()
        {
            for (int i = 0; i < array_año.Length; i++)
            {
                comboAño.Items.Add(array_año[i]);

            }
        }
        void desplegarAreas()
        {
            for (int i = 0; i < array_area.Length; i++)
            {
                comboArea.Items.Add(array_area[i]);
            }
        }
        void desplegarConceptos()
        {
            for (int i= 0; i<array_concepto.Length; i++)
            {
                comboConcepto.Items.Add(array_concepto[i]);
            }
        }
        //Eventos click para el diseño de los combos
        private void comboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEmpresa.BackColor = Color.White;
            comboEmpresa.ForeColor = Color.Black;
        }

        private void comboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboAño.BackColor = Color.White;
            comboAño.ForeColor = Color.Black;
        }

        private void comboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboArea.BackColor = Color.White;
            comboArea.ForeColor = Color.Black;
        }

        private void comboConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboConcepto.BackColor = Color.White;
            comboConcepto.ForeColor = Color.Black;
        }

        private void textHRS_Click(object sender, EventArgs e)
        {
            textHRS.BackColor = Color.White;
            textHRS.ForeColor = Color.Black;
        }

        private void picBoxNotaConcepto_MouseMove(object sender, MouseEventArgs e)
        {
            picBoxNotaConcepto.BackColor = Color.Goldenrod;
        }

        private void picBoxNotaConcepto_MouseLeave(object sender, EventArgs e)
        {
            picBoxNotaConcepto.BackColor = Color.DodgerBlue;
        }
        private void btnCapurarHr_MouseMove(object sender, MouseEventArgs e)
        {
            btnCapurarHr.BackColor = Color.Goldenrod;
        }
        private void btnCapurarHr_MouseLeave(object sender, EventArgs e)
        {
            btnCapurarHr.BackColor = Color.DodgerBlue;
        }
        private void btnVerHr_MouseMove(object sender, MouseEventArgs e)
        {
            btnVerHr.BackColor = Color.Goldenrod;
        }
        private void btnVerHr_MouseLeave(object sender, EventArgs e)
        {
            btnVerHr.BackColor = Color.DodgerBlue;
        }

        //Validaciones de campos
        int validacionUsuario()
        {
            if ((comboEmpresa.SelectedIndex <= -1) || (comboAño.SelectedIndex <= -1) || (comboConcepto.SelectedIndex <= -1))
            {
                return 1;
            }

            else
            {
                if((textHRS.Text.All(Char.IsLetter)) || (textHRS.Text.Contains(",")) || (textHRS.Text.Any(Char.IsLetter)) || (textHRS.Text == ""))
                {
                    return 2;
                }

                else 
                    if (comboArea.Text=="")
                        {
                         return 3;
                        }
                else
                {
                    return 0;
                }
            }
        }

        private void btnCapurarHr_Click(object sender, EventArgs e)
        {
            switch (validacionUsuario())
            {
                case 0:
                    {
                        //no hay ningun error
                        picError.Visible = false;
                        errorProviderUsuario.SetError(panel1, "");
                        errorProviderUsuario.SetError(textHRS, "");
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("validaciones basicas completas ", "Datos correctos", buttons);
                        break;
                    }
                case 1:
                    {
                        picError.Visible = true;
                        errorProviderUsuario.SetError(panel1, "Debe completar todos los datos del formulario");
                        break;
                    }
                case 2:
                    {
                        errorProviderUsuario.SetError(textHRS, "Ingresar horas numericas o decimales FORMATO 0.0");
                        textHRS.Focus();
                        break;
                    }
                case 3:
                    {
                        comboArea.Text = "Auditoria";
                        comboArea.BackColor = Color.White;
                        comboArea.ForeColor = Color.Black;
                        break;
                    }
            }
        }
        //Fin Validaciones de campos
    }
}

﻿using System;
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
        InsertarBD formulario = new InsertarBD();
        string[] array_empresa;
        string[] array_año;
        string[] array_area;
        string[] array_concepto;
        string comentario;
        string mensaje;
        string valorConcepto = "";

        public Usuario(string nombre)
        {
            InitializeComponent();
            txtOtrasAreas.Visible = false;
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
        //DISEÑO
        //Eventos click para el diseño de los combos
        private void comboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboEmpresa.BackColor = Color.White;
        }

        private void comboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboAño.BackColor = Color.White;
        }
        private void comboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboArea.BackColor = Color.White;
            if((comboArea.Text == "") || (comboArea.Text == "Auditoria")||(comboArea.SelectedIndex <= -1))
            {
                txtOtrasAreas.Visible = false;
                comboConcepto.Visible = true;
                txtOtrasAreas.Text = "";
            }
            else
            {
                txtOtrasAreas.Visible = true;
                comboConcepto.Visible = false;
                comboConcepto.Text = "";
            }
        }

        private void comboConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboConcepto.BackColor = Color.White;
        }
        private void txtOtrasAreas_TextChanged(object sender, EventArgs e)
        {
            txtOtrasAreas.BackColor = Color.White;
        }

        private void textHRS_Click(object sender, EventArgs e)
        {
            textHRS.BackColor = Color.White;
        }
        private void textHRS_TextChanged(object sender, EventArgs e)
        {
            textHRS.BackColor = Color.White;
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
            btnCapurarHr.ForeColor = Color.Black;
        }
        private void btnCapurarHr_MouseLeave(object sender, EventArgs e)
        {
            btnCapurarHr.BackColor = Color.DodgerBlue;
            btnCapurarHr.ForeColor = Color.White;
        }
        //FIN DISEÑO
        //Validaciones de campos
        int validacionUsuario()
        {
            if ((comboEmpresa.SelectedIndex <= -1)||(comboAño.SelectedIndex <= -1)||(comboConcepto.Visible == true && comboConcepto.SelectedIndex <= -1)||(txtOtrasAreas.Visible == true && txtOtrasAreas.Text==""))
            {
                return 1;
            }

            else
            {
                if ((textHRS.Text.All(Char.IsLetter)) || (textHRS.Text.Contains(",")) || (textHRS.Text.Any(Char.IsLetter)) || (textHRS.Text == ""))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
        //DESARROLLO DE BOTONES
        private void btnCapurarHr_Click(object sender, EventArgs e)
        {
            switch (validacionUsuario())
            {
                case 0:
                    {
                        //no hay ningun error
                        if(comboArea.Text=="")
                        {
                            comboArea.Text= "Auditoria";
                        }
                        picError.Visible = false;
                        errorProviderUsuario.SetError(panel1, "");
                        errorProviderUsuario.SetError(textHRS, "");
                        //comboEmpresa,comboAño,comboArea, comboConcepto, textHRS
                        //formulario.insertar(Convert.ToInt32(), );
                        if(comentario==null)
                        {
                            mensaje = "Fecha: " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "\nEmpresa: " + comboEmpresa.Text + "\nEjercicio: " + comboAño.Text + "\nArea: " + comboArea.Text + "\nConcepto: " + comboConcepto.Text + txtOtrasAreas.Text +"\nHoras: " + textHRS.Text +
                            "\n¿está seguro de registrar estos datos?";
                        }
                        else
                        {
                            mensaje = "Fecha: " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "\nEmpresa: " + comboEmpresa.Text + "\nEjercicio: " + comboAño.Text + "\nArea: " + comboArea.Text + "\nConcepto: " + comboConcepto.Text + txtOtrasAreas.Text + ", " + comentario + "\nHoras: " + textHRS.Text +
                            "\n¿está seguro de registrar estos datos?";
                        }
                        //retroalimentacion
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult dialogResult = MessageBox.Show(mensaje, "Confirmacion", buttons);
                        if(dialogResult==DialogResult.Yes)
                        {
                            Limpiar limpiar = new Limpiar();
                            limpiar.BorrarCampos(panel1);
                            comentario = "";
                            comboEmpresa.BackColor = Color.Silver;
                            comboAño.BackColor = Color.Silver;
                            comboArea.BackColor = Color.Silver;
                            comboConcepto.BackColor = Color.Silver;
                            txtOtrasAreas.BackColor = Color.Silver;
                            textHRS.BackColor = Color.Silver;
                        }
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
            }
        }
        //FIN DE DESARROLLO DE BOTONES
        //Fin Validaciones de campos

        //OBTENER VALORES DEL FORM NOTACONCEPTO:
        public Usuario(string concepto, string comentario)
        {
            InitializeComponent();
        }
        
        private void picBoxNotaConcepto_Click(object sender, EventArgs e)
        {
            if (comboConcepto.Visible == true)
            {
                valorConcepto = comboConcepto.Text;
            }
            else if(txtOtrasAreas.Visible==true)
            {
                valorConcepto = txtOtrasAreas.Text;
            }
            //paso datos usuario al form nota concepto
            NotaConcepto notaConcepto = new NotaConcepto(valorConcepto,comentario);
            notaConcepto.pasado += new NotaConcepto.pasar(ejecutar);
            notaConcepto.ShowDialog();
        }

        public void ejecutar(string dato, string dato2)
        {
            //aqui obtengo todos los datos del form NotaConcepto
            valorConcepto = dato;
            comentario= dato2;
        }
        //FINOBTENER VALORES DEL FORM NOTACONCEPTO
        //CERRAR APLICACION
        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

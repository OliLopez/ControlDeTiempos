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
        int variableRelacion=0;
        string sarea="/";
        string sempresa="/";
        string iEjercicio="0";
        string sempleado = "/";

        public Administrador()
        {
            InitializeComponent();
        }

        //Metodos para el Llenado de los combos
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
        //PRUEBAS
 
        //metodo para identificar tipo de relacion
        int relacion()
        {
            if (!(cmbEmpleado.SelectedIndex <= -1) && !(cmbEmpresa.SelectedIndex <= -1))
            {
                return 1;
            }
            if (!(cmbArea.SelectedIndex <= -1) && !(cmbEmpleado.SelectedIndex <= -1))
            {
                return 2;
            }
            if (!(cmbEmpresa.SelectedIndex <= -1) && !(cmbArea.SelectedIndex <= -1))
            {
                return 3;
            }
                //Relaciones generales
                if (!(cmbArea.SelectedIndex <= -1))
                {
                    return 4;
                }
                if (!(cmbEmpresa.SelectedIndex <= -1))
                {

                    return 5;
                }

                if (!(cmbEmpleado.SelectedIndex <= -1))
                {
                    return 6;
                }

            //POSDASTIALES
            if (cmbEmpleado.Text=="Todos" && !(cmbArea.Text == "Todos")&& !(cmbEmpresa.Text == "Todos"))
            {
                return 7;
            }
            if(cmbArea.Text == "Todos" && !(cmbEmpresa.Text == "Todos") && !(cmbEmpleado.Text == "Todos"))
            {
                return 8;
            }
            if (cmbEmpresa.Text == "Todos" &&!(cmbArea.Text == "Todos")&& !(cmbEmpleado.Text == "Todos"))
            {
                return 9;
            }
            //Especifico
            if (!(cmbArea.Text=="")&& !(cmbEmpresa.Text=="") && !(cmbEmpleado.Text==""))
            {
                return 10;
            }
            
            else
            {
             //consulta año
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
                        errorProviderAdmin.SetError(cmbAño, "");
                        //MOSTRAR EL REPORTE SOLICITADO:
                        switch (relacion())
                        {
                            case 1:
                                {
                                    //nombre, año, empresa
                                    variableRelacion = 1;
                                    break;
                                }
                            case 2:
                                {
                                    variableRelacion = 2;
                                    break;
                                }
                            case 3:
                                {
                                    variableRelacion = 3;
                                    break;
                                }
                            case 4:
                                {
                                    variableRelacion = 4;
                                    break;
                                }
                            case 5:
                                {
                                    variableRelacion = 5;
                                    break;
                                }
                            case 6:
                                {
                                    variableRelacion = 6;
                                    break;
                                }
                            case 7:
                                {
                                    variableRelacion = 7;
                                    break;
                                }
                            case 8:
                                {
                                    variableRelacion = 8;
                                    break;
                                }
                            case 9:
                                {
                                    variableRelacion = 9;
                                    break;
                                }
                            case 10:
                                {
                                    variableRelacion = 10;
                                    break;
                                }
                            case 0:
                                {
                                    variableRelacion = 0;
                                    break;
                                }
                        }
                        sempleado = cmbEmpleado.Text;
                        sarea = cmbArea.Text;
                        sempresa = cmbEmpresa.Text;
                        iEjercicio = cmbAño.Text;
                        using (Form_ReporteAdmin ventanaReporteGeneral = new Form_ReporteAdmin(variableRelacion,sarea,sempresa,iEjercicio,sempleado))
                            ventanaReporteGeneral.ShowDialog();
                        break;
                    }
                case 1:
                    {
                        errorProviderAdmin.SetError(cmbAño, "Seleccione un año");
                        cmbAño.Focus();
                        break;
                    }
            } 
        }
        //FIN DESAROLLO DE BOTONES
        //CERRAR APLICACION
        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

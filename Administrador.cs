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
        //Inicio Diseño 
        private void picBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            picBuscar.BackColor = Color.Goldenrod;
        }

        private void picBuscar_MouseLeave(object sender, EventArgs e)
        {
            picBuscar.BackColor = Color.Transparent;
        }

        private void picAB_MouseMove(object sender, MouseEventArgs e)
        {
            picAB.BackColor = Color.Goldenrod;
        }

        private void picAB_MouseLeave(object sender, EventArgs e)
        {
            picAB.BackColor = Color.Transparent;
        }
        private void picformModi_MouseMove(object sender, MouseEventArgs e)
        {
            picformModi.BackColor = Color.Goldenrod;
        }

        private void picformModi_MouseLeave(object sender, EventArgs e)
        {
            picformModi.BackColor = Color.Transparent;
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

        // ------------------inicio ALTABAJAS---------------------------------------------------
        private void picAB_Click(object sender, EventArgs e)
        {
            new AltaBajaForm().ShowDialog();
        }
        // ------------------fin ALTABAJAS---------------------------------------------------

        // ------------------inicio CONSULTAS---------------------------------------------------
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
        //metodo para identificar tipo de relacion
        int relacion()
        {
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
                
            if (cmbEmpleado.Text == "Todos" && (cmbArea.Text == "Todos") && (cmbEmpresa.Text == "Todos"))
            {
                return 10;
            }
            if (cmbEmpleado.Text == "Todos" && !(cmbArea.Text == "Todos") && (cmbEmpresa.Text == "Todos"))
            {
                return 11;
            }
            if (cmbEmpleado.Text == "Todos" && (cmbArea.Text == "Todos") && !(cmbEmpresa.Text == "Todos"))
            {
                return 12;
            }
            if (!(cmbEmpleado.Text == "Todos") && (cmbArea.Text == "Todos") && (cmbEmpresa.Text == "Todos"))
            {
                return 13;
            }
            //Especifico
            if (!(cmbArea.Text == "") && !(cmbEmpresa.Text == "") && !(cmbEmpleado.Text == ""))
            {
                return 14;
            }
            if ((!(cmbEmpleado.Text == "") && !(cmbEmpleado.Text == "Todos")) && (!(cmbEmpresa.Text == "") && !(cmbEmpresa.Text == "Todos")))
            {
                return 1;
            }
            if ( (!(cmbArea.Text=="") && !(cmbArea.Text=="Todos")) && (!(cmbEmpleado.Text=="")&& !(cmbEmpleado.Text=="Todos")) )
            {
                return 2;
            }
            if ((!(cmbEmpresa.Text=="") && !(cmbEmpresa.Text=="Todos")) && (!(cmbArea.Text=="")&& !(cmbArea.Text=="Todos")))
            {
                return 3;
            }
            if ( !(cmbArea.Text=="") && !(cmbArea.Text=="Todos") )
            {
                return 4;
            }

            if (!(cmbEmpresa.Text=="") && !(cmbEmpresa.Text=="Todos"))
            {

                return 5;
            }

            if (!(cmbEmpleado.Text=="") && !(cmbEmpleado.Text=="Todos"))
            {
                return 6;
            }
            else
            {
                //consulta año
                return 0;
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
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
                            case 11:
                                {
                                    variableRelacion = 11;
                                    break;
                                }
                            case 12:
                                {
                                    variableRelacion = 12;
                                    break;
                                }
                            case 13:
                                {
                                    variableRelacion = 13;
                                    break;
                                }
                            case 14:
                                {
                                    variableRelacion = 14;
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
                        using (Form_ReporteAdmin ventanaReporteGeneral = new Form_ReporteAdmin(variableRelacion, sarea, sempresa, iEjercicio, sempleado))
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
        // ------------------fin CONSULTAS---------------------------------------------------

        // ------------------inicio MODIFICAR---------------------------------------------------
        private void picformModi_Click(object sender, EventArgs e)
        {
            new Ventana_Modificar().ShowDialog();
        }
        // ------------------fin MODIFICAR---------------------------------------------------

        //CERRAR APLICACION
        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controlTiemposDataSet1.cmbEmpresa' table. You can move, or remove it, as needed.
            this.cmbEmpresaTableAdapter.Fill(this.ctDataSetcmEmpre.cmbEmpresa);
            // TODO: This line of code loads data into the 'controlTiemposDataSetempleado.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.controlTiemposDataSetempleado.empleado);
            // TODO: This line of code loads data into the 'controlTiemposDataSet.Ejercicio' table. You can move, or remove it, as needed.
            this.ejercicioTableAdapter.Fill(this.controlTiemposDataSet.Ejercicio);
            cmbAño.Text = "";
            cmbEmpleado.Text = "";
            cmbEmpresa.Text = "";
        }
    }
}

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
    public partial class Form_ReporteAdmin : Form
    {
        int ResultReport=0;
        string Rarea;
        string Rempr;
        string Ra;
        string Rempl;

        Reporte reporte = new Reporte();
        public Form_ReporteAdmin(int numRelacion, string area, string empres, string año, string empl)
        {
            InitializeComponent();
            ResultReport = numRelacion;
            Rarea = area;
            Rempr = empres;
            Ra = año;
            Rempl = empl;
            desplegarReporte();
            lblancho.Text = ResultReport.ToString();
        }

        public void desplegarReporte()
        {
            try
            {
                if (ResultReport == 1)
                {
                    reporte.empleado_empresa(dgvReporte, Rempl, Ra, Rempr);
                    this.toolTip.SetToolTip(btnotify, "Cuantas horas gasto un empleado en determinada empresa");
                    this.Size = new Size(565, 160);
                }
                if (ResultReport == 2)
                {
                    reporte.empleado_area(dgvReporte, Rempl, Ra, Rarea);
                    this.toolTip.SetToolTip(btnotify, "Cuantas horas gasto un empleado en determinada area");
                    this.Size = new Size(390, 160);
                }
                if (ResultReport == 3)
                {
                    reporte.empresa_area(dgvReporte, Rarea, Ra, Rempr);
                    this.toolTip.SetToolTip(btnotify, "Cuantas horas tiene una empresa en determinada area");
                    this.Size = new Size(475, 160);
                }
                if (ResultReport == 4)
                {
                    reporte.area(dgvReporte, Rarea, Ra);
                    this.toolTip.SetToolTip(btnotify, "Cuantas horas tiene un area en un año");
                    this.Size = new Size(290, 160);
                }
                if (ResultReport == 5)
                {
                    reporte.empresa(dgvReporte, Rempr, Ra);
                    this.toolTip.SetToolTip(btnotify, "Cuantas horas tiene una empresa en un año");
                    this.Size = new Size(515, 160);
                }
                if (ResultReport == 6)
                {
                    reporte.empleado(dgvReporte, Rempl, Ra);
                    this.toolTip.SetToolTip(btnotify, "Total horas por todos los servicios del empleado seleccionado");
                    this.Size = new Size(730, 200);
                }

                if (ResultReport == 7)
                {
                    reporte.todos_empleado(dgvReporte,Ra);
                    this.toolTip.SetToolTip(btnotify, "Total horas de todos los empleados");
                    this.Size = new Size(370, 270);
                    
                }
                if (ResultReport == 8)
                {
                    reporte.todos_area(dgvReporte,Ra);
                    this.toolTip.SetToolTip(btnotify, "Total horas de todas las Areas");
                    this.Size = new Size(370, 270);
                   
                }
                if (ResultReport == 9)
                {
                    reporte.todos_empresa(dgvReporte,Ra);
                    this.toolTip.SetToolTip(btnotify, "Total horas de todas las empresas");
                    this.Size = new Size(575, 270);
                    
                }
                if (ResultReport == 10)
                {
                    reporte.con_especifico(dgvReporte,Rempl,Rarea,Ra,Rempr);
                    this.Size = new Size(565, 270);
                    this.toolTip.SetToolTip(btnotify, "Total horas de un empleado en un area especifica y empresa seleccionada");
                }
                if (ResultReport == 0)
                {
                    reporte.ejercicio(dgvReporte,Ra);
                    this.toolTip.SetToolTip(btnotify, "Total de horas del año contable seleccionado");
                    this.Size = new Size(830, 270);
                    
                }
            }
            catch (Exception)
            {
                reporte.ejercicio(dgvReporte, Ra);
                this.toolTip.SetToolTip(btnotify, "Total de horas del año contable seleccionado");
                this.Size = new Size(830, 270);
            }
        }
        //prueba medidas
        private void button1_Click(object sender, EventArgs e)
        {
            string anchoform;
            anchoform = this.Size.ToString();
            lblancho.Text = anchoform;
        }

        private void btnotify_Click(object sender, EventArgs e)
        {
            if (ResultReport == 0)
            {
                this.toolTip.SetToolTip(btnotify, "Total de horas del año contable seleccionado");
            }
            if (ResultReport == 1)
            {
                this.toolTip.SetToolTip(btnotify, "Cuantas horas gasto un empleado en determinada empresa");
            }
            if (ResultReport == 2)
            {
                this.toolTip.SetToolTip(btnotify, "Cuantas horas gasto un empleado en determinada area");
            }
            if (ResultReport == 3)
            {
                this.toolTip.SetToolTip(btnotify, "Cuantas horas tiene una empresa en determinada area");
            }
            if (ResultReport == 4)
            {
                this.toolTip.SetToolTip(btnotify, "Cuantas horas tiene un area en un año");
            }
            if (ResultReport == 5)
            {
                this.toolTip.SetToolTip(btnotify, "Cuantas horas tiene una empresa en un año");
            }
            if (ResultReport == 6)
            {
                this.toolTip.SetToolTip(btnotify, "Total horas por todos los servicios del empleado seleccionado");
            }
            if (ResultReport == 7)
            {
                this.toolTip.SetToolTip(btnotify, "Total horas de todos los empleados");
            }
            if (ResultReport == 8)
            {
                this.toolTip.SetToolTip(btnotify, "Total horas de todas las Areas");
            }
            if (ResultReport == 9)
            {
                this.toolTip.SetToolTip(btnotify, "Total horas de todas las empresas");
            }
            if (ResultReport == 10)
            {
                this.toolTip.SetToolTip(btnotify, "Total horas de un empleado en un area especifica y empresa seleccionada");
            }
        }
    }
}

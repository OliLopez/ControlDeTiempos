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
        }

        public void desplegarReporte()
        {
            if(ResultReport==1)
            {
                reporte.empleado_empresa(dgvReporte,Rempl,Ra,Rempr);
                this.toolTip.SetToolTip(lblNotifi, "Cuantas horas gasto un empleado en determinada empresa");
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Size = new Size(565, 135);
            }
            if (ResultReport == 2)
            {
                reporte.empleado_area(dgvReporte,Rempl,Ra,Rarea);
                this.toolTip.SetToolTip(lblNotifi, "Cuantas horas gasto un empleado en determinada area");
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Size = new Size(390, 135);
            }
            if (ResultReport == 3)
            {
                reporte.empresa_area(dgvReporte,Rarea,Ra,Rempr);
                this.toolTip.SetToolTip(lblNotifi, "Cuantas horas tiene una empresa en determinada area");
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Size = new Size(565, 135);
            }
            if (ResultReport == 4)
            {
                reporte.area(dgvReporte, Rarea, Ra);
                this.toolTip.SetToolTip(lblNotifi, "Cuantas horas tiene un area en un año");
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Size = new Size(290, 150);
            }
            if (ResultReport == 5)
            {
                reporte.empresa(dgvReporte, Rempr, Ra);
                this.toolTip.SetToolTip(lblNotifi, "Cuantas horas tiene una empresa en un año");
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Size = new Size(565, 135);
            }
            if (ResultReport == 6)
            {
                reporte.empleado(dgvReporte, Rempl, Ra);
                this.toolTip.SetToolTip(lblNotifi, "Total horas por todos los servicios del empleado seleccionado");
                this.Size = new Size(1240, 150);
            }
        }
        //prueba medidas
        private void button1_Click(object sender, EventArgs e)
        {
            //this.Size = new Size(1300, 328);
            string anchoform;
            anchoform = this.Size.ToString();
            lblancho.Text = anchoform;
        }

        private void lblNotifi_Click(object sender, EventArgs e)
        {
            if (ResultReport == 1)
            {
                this.toolTip.SetToolTip(lblNotifi, "Cuantas horas gasto un empleado en determinada empresa");
            }
            if (ResultReport == 2)
            {
                this.toolTip.SetToolTip(lblNotifi, "Cuantas horas gasto un empleado en determinada area");
            }
            if (ResultReport == 3)
            {
                this.toolTip.SetToolTip(lblNotifi, "Cuantas horas tiene una empresa en determinada area");
            }
            if (ResultReport == 4)
            {
                this.toolTip.SetToolTip(lblNotifi, "Cuantas horas tiene un area en un año");
            }
            if (ResultReport == 5)
            {
                this.toolTip.SetToolTip(lblNotifi, "Cuantas horas tiene una empresa en un año");
            }
            if (ResultReport == 6)
            {
                this.toolTip.SetToolTip(lblNotifi, "Total horas por todos los servicios del empleado seleccionado");
            }
        }
    }
}

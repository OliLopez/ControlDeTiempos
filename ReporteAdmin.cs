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
    public partial class ReporteAdmin : Form
    {
        Reporte reporte = new Reporte();
        public ReporteAdmin()
        {
            InitializeComponent();
            reporte.cargarHoras(dgvReporte);
            this.Size = new Size(590, 450);
            dgvReporte.Size = new Size(500, 450);
        }

    }
}

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
    public partial class Ventana_Modificar : Form
    {
        Clase_ABM mostrar = new Clase_ABM();
        string mempleado = "/";
        string mejercicio = "/";
        string  id="0";
        string registro_Eliminar="";
        //OBTENER EL TITULO DE LA Columna
        string columnSelect;
        string columFecha;
        string columnEmpresa;
        string columnArea;
        string columnConcepto;
        string columnComentario;
        string columnHoras;

        public Ventana_Modificar()
        {
            InitializeComponent();
            toolTip1.SetToolTip(picEliminar, "doble click al numero de la columna '#' para eliminar");
        }
        private void picVer_MouseLeave(object sender, EventArgs e)
        {
            picVer.BackColor = Color.Transparent;
        }

        private void picVer_MouseMove(object sender, MouseEventArgs e)
        {
            picVer.BackColor = Color.Goldenrod;
        }
        private void picGuardar_MouseLeave(object sender, EventArgs e)
        {
            picGuardar.BackColor = Color.Transparent;
        }

        private void picGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            picGuardar.BackColor = Color.Goldenrod;
        }

        private void picEliminar_MouseLeave(object sender, EventArgs e)
        {
            picEliminar.BackColor = Color.Transparent;
        }

        private void picEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            picEliminar.BackColor = Color.Goldenrod;
        }

        private void picVer_Click_1(object sender, EventArgs e)
        {
             dgvModificar.ReadOnly = false;
             mempleado = cmbModificar.Text;
             mejercicio = cmbAñoModificar.Text;
             mostrar.Modiempleado(dgvModificar, mempleado, mejercicio);
             if (cmbModificar.Text == "Todos")
             {
                 mostrar.todos(dgvModificar, mejercicio);
                dgvModificar.ReadOnly = true;
             }
        }
        //OBTENER EL VALOR CAMBIADO Y REALIZAR UNA ACCION AL RESPECTO UNA VEZ CAMBIADO
        private void dgvModificar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            columnSelect = dgvModificar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            id = dgvModificar.Rows[e.RowIndex].Cells[0].Value.ToString();
            columFecha = dgvModificar.Rows[e.RowIndex].Cells[1].Value.ToString();
            columnEmpresa = dgvModificar.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
            columnArea = dgvModificar.Rows[e.RowIndex].Cells[3].Value.ToString(); ;
            columnConcepto = dgvModificar.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
            columnComentario = dgvModificar.Rows[e.RowIndex].Cells[5].Value.ToString(); ;
            columnHoras = dgvModificar.Rows[e.RowIndex].Cells[6].Value.ToString(); ;
            //si a la celda que estoy seleccionando es igual a la columna 
            if (columnSelect==columFecha)
            {
                mostrar.acFecha(columnSelect, Convert.ToInt32(id));
            }
            if (columnSelect == columnEmpresa)
            {
                mostrar.acEmpresa(columnSelect, Convert.ToInt32(id));
            }
            if (columnSelect == columnArea)
            {
                mostrar.acArea(columnSelect, Convert.ToInt32(id));
            }
            if (columnSelect == columnConcepto)
            {
                mostrar.acConcepto(columnSelect, Convert.ToInt32(id));
            }
            if (columnSelect == columnComentario)
            {
                mostrar.acComentario(columnSelect,Convert.ToInt32(id));
            }
            if (columnSelect == columnHoras)
            {
                mostrar.acHoras(float.Parse(columnSelect), Convert.ToInt32(id));
            }
        }

        private void Ventana_Modificar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controlTiemposDataSetempleado.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.controlTiemposDataSetempleado.empleado);
            cmbModificar.Text = "";
        }

        private void dgvModificar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvModificar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            lblNum.Text = id;
            registro_Eliminar = dgvModificar.Rows[e.RowIndex].Cells[1].Value.ToString() + ", " + dgvModificar.Rows[e.RowIndex].Cells[2].Value.ToString() + ", " + dgvModificar.Rows[e.RowIndex].Cells[3].Value.ToString() + ", " + dgvModificar.Rows[e.RowIndex].Cells[4].Value.ToString() + ", " + dgvModificar.Rows[e.RowIndex].Cells[5].Value.ToString() + ", Hora: " + dgvModificar.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        private void picEliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el siguiente registro: \n" + registro_Eliminar + "?", "Confirmacion", buttons);

            if (dialogResult == DialogResult.Yes)
            {
                //eliminar
                mostrar.registroBaja(Convert.ToInt32(id));
                mostrar.Modiempleado(dgvModificar, mempleado, mejercicio);
                lblNum.Text = "#";
            }
        }
    }
}

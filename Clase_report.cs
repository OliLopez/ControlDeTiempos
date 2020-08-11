using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ControlDeTiempos
{
    class Reporte
    {
        SqlConnection sqlConexion;
        SqlDataAdapter da;
        DataTable dt;

        public Reporte()
        {
            try
            {
                sqlConexion = new SqlConnection("Data Source=DESKTOP-RH8U25N\\SQLEXPRESS;Initial Catalog=ControlTiempos;Integrated Security=True");
                sqlConexion.Open();
                Console.WriteLine("Base de datos conectada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("No se conecto a la Base de datos...");
            }
        }
        
        public void cargarHoras(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Registro", sqlConexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta: \n" + ex.ToString());
            }
        }
    }
}

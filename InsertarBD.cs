using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControlDeTiempos
{
    class InsertarBD
    {
        SqlConnection sqlConexion;
        SqlCommand sqlComando;
    
        public InsertarBD()
        {
            try
            {
                sqlConexion = new SqlConnection("Data Source=DESKTOP-RH8U25N\\SQLEXPRESS;Initial Catalog=ControlTiempos;Integrated Security=True");
                sqlConexion.Open();
                Console.WriteLine("Base de datos conectada");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("No se conecto a la Base de datos...");
            }
        }

        public string insertar(int id, string fecha, string empresa, int ejercicio, string area, string concepto, string comentario, float horas)
        {
            string salida = "DATOS REGISTRADOS";
            
            try
            {
                sqlComando = new SqlCommand("Insert into Registro(Id_Empleado, Fecha, Empresa, Ejercicio, Area, Concepto, Comentario, Horas) values(" +id+", '"+fecha+"', '"+empresa+"', "+ejercicio+", '"+area+"', '"+concepto+"','"+comentario+"',"+horas+")", sqlConexion);
                sqlComando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                salida = "Error en la inserccion de datos: " + ex.ToString();
            }
            MessageBoxTemporal.Show(salida, " ", 3, true);
            return salida;
        }
    }
}

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
    class InsertarBD
    {
        SqlConnection sqlConexion;
        SqlCommand sqlComando;
    
        public InsertarBD()
        {
            try
            {
                sqlConexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ControlTiempos;Integrated Security=True");
                //DESKTOP - RH8U25N
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
            MessageBoxTemporal.Show(salida, " ", 2, true);
            return salida;
        }

        public float MesTotal(int id, string mesActual)
        {
            float result=0;
            string cadena="0";
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlcmd = new SqlCommand("SELECT DATEPART(month, Fecha), SUM(Horas) FROM Registro where Id_Empleado=@i and MONTH(Fecha)=@ma GROUP BY DATEPART(month, Fecha)", sqlConexion);
                sqlcmd.Parameters.AddWithValue("i", id);
                sqlcmd.Parameters.AddWithValue("ma", mesActual);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                sda.Fill(dt);
                cadena = dt.Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                string r = "Error en la inserccion de datos: " + ex.ToString();
            }
            return result = float.Parse(cadena);
        }

        public float diaTotal(int id, string diaActual)
        {
            float r = 0;
            string c = "0";
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlcmd = new SqlCommand("SELECT DATEPART(DAY, Fecha), SUM(Horas) FROM Registro where Id_Empleado=@id and DAY(Fecha)=@da GROUP BY DATEPART(DAY, Fecha)", sqlConexion);
                sqlcmd.Parameters.AddWithValue("id", id);
                sqlcmd.Parameters.AddWithValue("da", diaActual);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                sda.Fill(dt);
                c = dt.Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                string salida = "Error en la inserccion de datos: " + ex.ToString();
            }
            return r = float.Parse(c);
        }

    }
}

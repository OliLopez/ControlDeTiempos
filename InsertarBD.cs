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
        SqlDataAdapter sqlAdapter;

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

        public string insertar(int c1, string c2, string c3)
        {
            string salida = "Se insertaron los datos";
            try
            {
                sqlComando = new SqlCommand("Insert into tabla(Campo1, Campo2, Campo3) values("+c1+", '"+c2+"', '"+c3+"')", sqlConexion);
                sqlComando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                salida = "Error en la inserccion de datos: " + ex.ToString();
            }
            return salida;
        }
        //ver si se usara en realidad metodo para evitar datos repetitivos... min 13:34
    }
}

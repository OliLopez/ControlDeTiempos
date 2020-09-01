using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ControlDeTiempos
{
    class Clase_ABM
    {
        SqlConnection sqlConexion;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        public Clase_ABM()
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

        public void empleados(DataGridView dgv)
        {
            try
            {
                string consulta = "select l.Nombre as Empleado FROM LogIn l where Tipo_usuario='Usuario'";
                sqlcmd = new SqlCommand(consulta, sqlConexion);
                da = new SqlDataAdapter(sqlcmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta: \n" + ex.ToString());
            }
        }

        public void empresas(DataGridView dgv)
        {
            try
            {
                string consulta = "select e.Nombre_Empresa as Empresa From Empresa e";
                sqlcmd = new SqlCommand(consulta, sqlConexion);
                da = new SqlDataAdapter(sqlcmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta: \n" + ex.ToString());
            }
        }
        //Modificar
        //todos
        public void todos(DataGridView dgv,string ej)
        {
            try
            {
                string consulta = "select li.Nombre,Empresa,Area,Concepto, Comentario,Horas from Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where Ejercicio=@ej";
                sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("ej", ej);
                da = new SqlDataAdapter(sqlcmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta: \n" + ex.ToString());
            }
        }
        public void Modiempleado(DataGridView dgv, string name, string año)
        {
            try
            {
                string consulta = "select Fecha,Empresa,Area,Concepto,Comentario,Horas from Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Ejercicio=@ej";
                sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("n", name);
                sqlcmd.Parameters.AddWithValue("ej", año);
                da = new SqlDataAdapter(sqlcmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta: \n" + ex.ToString());
            }
        }

        public void login(DataGridView dgv)
        {
            try
            {
                string consulta = "select Nombre, Usuario, Contra as Contraseña from LogIn";
                sqlcmd = new SqlCommand(consulta, sqlConexion);
                da = new SqlDataAdapter(sqlcmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta: \n" + ex.ToString());
            }
        }
        //Altas
        public string nuevoUsuario(string name, string alias, string pass, string tipoUsuario)
        {
            string salida = "Usuario registrado";

            try
            {
                sqlcmd = new SqlCommand("Insert into LogIn(Nombre,Usuario,Contra,Tipo_usuario) values('" + name + "', '" + alias + "','" + pass + "', '" + tipoUsuario + "')", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                salida = "Error en la inserccion de datos: " + ex.ToString();
            }
            MessageBoxTemporal.Show(salida, " ",2,true);
            return salida;
        }
        public void cmbAdmin(string name)
        {
            string salida;

            try
            {
                sqlcmd = new SqlCommand("Insert into empleado(Nombre) values('" + name + "')", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                salida = "Error en la inserccion de datos: " + ex.ToString();
            }
        }
        //ALTAS EJERCICIO, EMPRESA, CONCEPTO
        public string nuevoAño(string ej)
        {
            string salida = "Año registrado";

            try
            {
                sqlcmd = new SqlCommand("Insert into Ejercicio(Nombre_Ejercicio) values('" +ej + "')", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                salida = "Error en la inserccion de datos: " + ex.ToString();
            }
            MessageBoxTemporal.Show(salida, " ", 2, true);
            return salida;
        }
        public string nuevoConcepto(string c)
        {
            string salida = "Concepto registrado";

            try
            {
                sqlcmd = new SqlCommand("Insert into Concepto(Nombre_Concepto) values('" + c + "')", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                salida = "Error en la inserccion de datos: " + ex.ToString();
            }
            MessageBoxTemporal.Show(salida, " ", 2, true);
            return salida;
        }
        public string nuevaEmpresa(string empresa)
        {
            string salida = "Empresa registrada";

            try
            {
                sqlcmd = new SqlCommand("Insert into Empresa(Nombre_Empresa) values('" +empresa + "')", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                salida = "Error en la inserccion de datos: " + ex.ToString();
            }
            MessageBoxTemporal.Show(salida, " ", 2, true);
            return salida;
        }
        public void cmbEmpresa(string cmbempre)
        {
            string salida;

            try
            {
                sqlcmd = new SqlCommand("Insert into cmbEmpresa(Nombre_Empresa) values('" + cmbempre + "')", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                salida = "Error en la inserccion de datos: " + ex.ToString();
            }
        }
    }
}

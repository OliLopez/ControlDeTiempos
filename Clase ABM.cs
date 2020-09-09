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
        string consultaModiEMpleado;
        //Modificar
        SqlDataAdapter msda;
        DataTable mdt;

        public Clase_ABM()
        {
            try
            {
                sqlConexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ControlTiempos;Integrated Security=True");
                //DESKTOP - RH8U25N
                sqlConexion.Open();
                Console.WriteLine("Base de datos conectada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("No se conecto a la Base de datos...");
            }
        }
        //Mostrar
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
                string consulta = "select Fecha,li.Nombre,Empresa,Area,Concepto, Comentario,Horas from Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where Ejercicio=@ej";
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
                consultaModiEMpleado = "select Id_Registro,Fecha,Empresa,Area,Concepto,Comentario,Horas from Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre='" + name + "' and Ejercicio='" + año + "'";
                msda = new SqlDataAdapter(consultaModiEMpleado,sqlConexion);
                mdt = new DataTable();
                msda.Fill(mdt);
                dgv.DataSource = mdt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta: \n" + ex.ToString());
            }
        }
        //actualizar
        public void acFecha(string fecha, int id)
        {
            try
            {
                sqlcmd = new SqlCommand(" UPDATE Registro SET Fecha ='" + fecha + "' WHERE Id_Registro='" + id + "'", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar actualizacion: \n" + ex.ToString());
            }
        }
        public void acEmpresa(string empresa, int id)
        {
            try
            {
                sqlcmd = new SqlCommand(" UPDATE Registro SET Empresa ='" + empresa + "' WHERE Id_Registro='" + id + "'", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar actualizacion: \n" + ex.ToString());
            }
        }
        public void acArea(string area, int id)
        {
            try
            {
                sqlcmd = new SqlCommand(" UPDATE Registro SET Area ='" + area + "' WHERE Id_Registro='" + id + "'", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar actualizacion: \n" + ex.ToString());
            }
        }
        public void acConcepto(string concep, int id)
        {
            try
            {
                sqlcmd = new SqlCommand(" UPDATE Registro SET Concepto ='" + concep + "' WHERE Id_Registro='" + id + "'", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar actualizacion: \n" + ex.ToString());
            }
        }
        public void acComentario(string coment, int id)
        {
            try
            {
                sqlcmd = new SqlCommand(" UPDATE Registro SET Comentario ='" + coment + "' WHERE Id_Registro='" + id + "'", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar actualizacion: \n" + ex.ToString());
            }
        }

        public void acHoras(float horas, int id)
        {
            try
            {
                sqlcmd = new SqlCommand(" UPDATE Registro SET Horas ='" + horas + "' WHERE Id_Registro='" + id + "'", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar actualizacion: \n" + ex.ToString());
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
        //Modificar-Altas
        public string registroBaja(int id)
        {
            string salida = "Registro eliminado";

            try
            {
                sqlcmd = new SqlCommand("delete from Registro where Id_Registro='" + id + "'", sqlConexion);
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
        public void nuevoAño(int ej)
        {
            string salida = "Año registrado";

            try
            {
                sqlcmd = new SqlCommand("Insert into Ejercicio(Nombre_Ejercicio) values(" +ej + ")", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                salida = "Error en la inserccion de datos: " + ex.ToString();
            }
            MessageBoxTemporal.Show(salida, " ", 2, true);
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
        //Bajas
        public string empresaBaja(string empresa)
        {
            string salida = "Empresa eliminada";

            try
            {
                sqlcmd = new SqlCommand("delete from Empresa where Nombre_Empresa='" + empresa + "'", sqlConexion);
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
        public string empleadoBaja(string empleado)
        {
            string salida = "Empleado eliminado";

            try
            {
                sqlcmd = new SqlCommand("delete from LogIn where Nombre='"+empleado+"'", sqlConexion);
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
        //BajasCombos
        public void cmbempl_Baja(string empleado)
        {
            string salida = "";

            try
            {
                sqlcmd = new SqlCommand("delete from empleado where Nombre='" + empleado + "'", sqlConexion);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //en caso de que un dato este mal escrito o no coincida en la tabla:
                salida = "Error en la inserccion de datos: " + ex.ToString();
            }
        }
        public void cmbempr_Baja(string empr)
        {
            string salida = "";

            try
            {
                sqlcmd = new SqlCommand("delete from cmbEmpresa where Nombre_Empresa='" + empr + "'", sqlConexion);
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

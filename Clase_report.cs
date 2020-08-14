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

        public void empleado_empresa(DataGridView dgv, string name, string año,string empresa)
        {
            try
            {
                string consulta = "select li.Nombre,Empresa,Ejercicio,Area, SUM(Horas) as HRS FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre =@n and Ejercicio = @ej and Empresa =@em GROUP BY li.Nombre,Area,Empresa,Ejercicio";
                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("n", name);
                sqlcmd.Parameters.AddWithValue("ej", año);
                sqlcmd.Parameters.AddWithValue("em", empresa);
                da = new SqlDataAdapter(sqlcmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta: \n" + ex.ToString());
            }
        }
        public void empleado_area(DataGridView dgv, string name, string año, string area)
        {
            try
            {
string consulta = "select distinct Area,substring((select ', '+convert(varchar(10), Ejercicio) AS [text()]from Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Ejercicio=@ej and Area=@a group by li.Nombre, Ejercicio FOR XML PATH ('')), 2,1000)[Ejercicio],substring((select ', '+ li.Nombre AS [text()]from Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Ejercicio=@ej and Area=@a group by li.Nombre, Ejercicio FOR XML PATH ('')), 2,1000)[Empleado],sum(Horas)as HRS from Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Ejercicio=@ej and Area=@a group by Area";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("n", name);
                sqlcmd.Parameters.AddWithValue("ej", año);
                sqlcmd.Parameters.AddWithValue("a", area);
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
        public void empresa_area(DataGridView dgv, string area, string ej, string empre)
        {
            try
            {
                string consulta = "select Area,Ejercicio,Empresa,SUM(Horas) as HRS FROM Registro where Area=@a and Ejercicio=@ej and Empresa=@em GROUP BY  Area, Ejercicio,Empresa";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("a", area);
                sqlcmd.Parameters.AddWithValue("ej", ej);
                sqlcmd.Parameters.AddWithValue("em", empre);
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
        public void area(DataGridView dgv, string area, string ej)
        {
            try
            {
                string consulta = "select Area,Ejercicio,SUM(Horas) as HRS FROM Registro where Area=@a and Ejercicio=@ej GROUP BY  Area,Ejercicio";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("a", area);
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
        public void empresa(DataGridView dgv, string empre, string ej)
        {
            try
            {
                string consulta = "select distinct Empresa,SUBSTRING((select ', '+CONVERT(varchar(10), Ejercicio) AS [text()]FROM Registro where Ejercicio=@ej and Empresa=@em GROUP BY Ejercicio FOR XML PATH ('')), 2,1000) [Ejercicio],SUBSTRING((SELECT ', '+ li.Nombre AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where Ejercicio=@ej and Empresa=@em GROUP BY li.Nombre FOR XML PATH ('')), 2,1000) [Empleado],sum(Horas) as HRS from Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where Ejercicio=@ej and Empresa=@em group by Empresa";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("em", empre);
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
        public void empleado(DataGridView dgv, string empleado, string ej)
        {
            try
            {
                string consulta = "select distinct li.Nombre,SUBSTRING((select ', '+CONVERT(varchar(10), Ejercicio) AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario WHERE li.Nombre=@emple and Ejercicio=@ej GROUP BY Ejercicio FOR XML PATH ('')), 2,1000) [Ejercicio],SUBSTRING((SELECT ', '+r.Area  AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario WHERE li.Nombre=@emple and Ejercicio=@ej GROUP BY Area FOR XML PATH ('')), 2,1000) [Area],SUBSTRING((SELECT ', '+r.Empresa  AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario WHERE li.Nombre=@emple and Ejercicio=@ej GROUP BY Empresa FOR XML PATH ('')), 2,1000) [Empresa],SUM(Horas) as HRS FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@emple and Ejercicio=@ej GROUP BY li.Nombre";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("emple", empleado);
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
    }
}

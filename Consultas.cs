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
        //1
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
        //2
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
        //3
        public void empresa_area(DataGridView dgv, string area, string ej, string empre)
        {
            try
            {
                string consulta = "select Empresa,Area,Ejercicio,SUM(Horas) as HRS FROM Registro where Area=@a and Ejercicio=@ej and Empresa=@em GROUP BY  Area, Ejercicio,Empresa";

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
        //4
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
        //5
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
        //6
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
        //CORREGIR
        //7
        public void todos_empleado(DataGridView dgv,string ej,string empre,string area)
        {
            try
            {
                string consulta = "select distinct Empresa,Area,SUBSTRING((select ', '+CONVERT(varchar(10), Ejercicio) AS [text()]FROM Registro where Ejercicio=@ej and Empresa=@e and Area=@a GROUP BY Ejercicio FOR XML PATH ('')), 2,1000) [Ejercicio],SUBSTRING((SELECT ', '+ li.Nombre AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where Ejercicio=@ej and Empresa=@e and Area=@a GROUP BY li.Nombre FOR XML PATH ('')), 2,1000) [Empleados],sum(Horas) as HRS from Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where Ejercicio=@ej and Empresa=@e and Area=@a group by Empresa, Area";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("ej", ej);
                sqlcmd.Parameters.AddWithValue("e", empre);
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
        //8
        public void todos_area(DataGridView dgv, string ej,string empleado,string empresa)
        {
            try
            {
                string consulta = "SELECT DISTINCT Empresa,li.Nombre,SUBSTRING((SELECT ', '+r.Area  AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Ejercicio=@ej and Empresa=@e GROUP BY Area FOR XML PATH ('')), 2,1000) [Areas],SUBSTRING((SELECT ', '+CONVERT(varchar(10), Ejercicio) AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Ejercicio=@ej and Empresa=@e GROUP BY Ejercicio FOR XML PATH ('')), 2,1000) [Ejercicio],SUM(Horas) as HRS FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Ejercicio=@ej and Empresa=@e GROUP BY li.Nombre,Empresa";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("ej", ej);
                sqlcmd.Parameters.AddWithValue("n", empleado);
                sqlcmd.Parameters.AddWithValue("e", empresa);
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
        //9
        public void todos_empresa(DataGridView dgv, string ej, string nombre,string area)
        {
            try
            {
                string consulta = "SELECT DISTINCT li.Nombre,Area,SUBSTRING((SELECT ', '+CONVERT(varchar(10), Ejercicio) AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Area=@a and Ejercicio=@ej GROUP BY Ejercicio FOR XML PATH ('')), 2,1000) [Ejercicio],SUBSTRING((SELECT ', '+r.Empresa  AS [text()] FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Area=@a and Ejercicio=@ej GROUP BY Empresa FOR XML PATH ('')), 2,1000) [Empresas],SUM(Horas) as HRS FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Area=@a and Ejercicio=@ej GROUP BY li.Nombre,Area";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("ej", ej);
                sqlcmd.Parameters.AddWithValue("n", nombre);
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
        //10
        public void con_especifico(DataGridView dgv, string e,string area, string ej, string empresa)
        {
            try
            {
                string consulta = "select Area,Ejercicio,li.Nombre,Empresa,SUM(Horas) as HRS FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where Area=@a and Ejercicio=@ej and Empresa=@em and li.Nombre=@n GROUP BY  Area, Ejercicio,Empresa,li.Nombre";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("n", e);
                sqlcmd.Parameters.AddWithValue("a", area);
                sqlcmd.Parameters.AddWithValue("ej", ej);
                sqlcmd.Parameters.AddWithValue("em", empresa);
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
        //0
        public void ejercicio (DataGridView dgv, string ej)
        {
            try
            {
                string consulta = "SELECT DISTINCT Ejercicio,SUBSTRING((SELECT ', '+ li.Nombre AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario WHERE Ejercicio=@ej GROUP BY li.Nombre FOR XML PATH ('')), 2,1000) [Empleado],SUBSTRING((SELECT ', '+r.Area  AS [text()]FROM Registro r WHERE Ejercicio=@ej GROUP BY Area FOR XML PATH ('')), 2,1000) [Area],SUBSTRING((SELECT ', '+r.Empresa  AS [text()]FROM Registro r WHERE Ejercicio=@ej GROUP BY Empresa FOR XML PATH ('')), 2,1000) [Empresa],sum(Horas) as HRS from Registro where Ejercicio=@ej group by Ejercicio";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
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
        //11
        public void empleados_empresas(DataGridView dgv, string ej,string area)
        {
            try
            {
                string consulta = "SELECT DISTINCT Area,SUBSTRING((SELECT ', '+CONVERT(varchar(10), Ejercicio) AS [text()]FROM Registro r where Area=@a and Ejercicio=@ej GROUP BY Ejercicio FOR XML PATH ('')), 2,1000) [Ejercicio],SUBSTRING((SELECT ', '+r.Empresa  AS [text()] FROM Registro r  where  Area=@a and Ejercicio=@ej GROUP BY Empresa FOR XML PATH ('')), 2,1000) [Empresas],SUBSTRING((SELECT ', '+ li.Nombre AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where Ejercicio=@ej and  Area=@a GROUP BY li.Nombre FOR XML PATH ('')), 2,1000) [Empleados],SUM(Horas) as HRS FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where Area=@a and Ejercicio=@ej GROUP BY Area";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("ej", ej);
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
        //12
        public void empleados_areas(DataGridView dgv, string ej, string emp)
        {
            try
            {
                string consulta = "SELECT DISTINCT Empresa,SUBSTRING((SELECT ', '+CONVERT(varchar(10), Ejercicio) AS [text()]FROM Registro r where Empresa=@e and Ejercicio=@ej GROUP BY Ejercicio FOR XML PATH ('')), 2,1000) [Ejercicio],SUBSTRING((SELECT ', '+r.Area  AS [text()]FROM Registro r  where Empresa=@e and Ejercicio=@ej GROUP BY Area FOR XML PATH ('')), 2,1000) [Areas],SUBSTRING((SELECT ', '+ li.Nombre AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where Ejercicio=@ej and Empresa=@e GROUP BY li.Nombre FOR XML PATH ('')), 2,1000) [Empleados],SUM(Horas) as HRS FROM Registro r where  Empresa=@e and Ejercicio=@ej GROUP BY Empresa";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("ej", ej);
                sqlcmd.Parameters.AddWithValue("e", emp);
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
        //13
        public void empresas_areas(DataGridView dgv, string ej, string name)
        {
            try
            {
                string consulta = "SELECT DISTINCT li.Nombre,SUBSTRING((SELECT ', '+r.Area  AS [text()]FROM Registro r  inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Ejercicio=@ej GROUP BY Area FOR XML PATH ('')), 2,1000) [Areas],SUBSTRING((SELECT ', '+CONVERT(varchar(10), Ejercicio) AS [text()]FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Ejercicio=@ej GROUP BY Ejercicio FOR XML PATH ('')), 2,1000) [Ejercicio],SUBSTRING((SELECT ', '+r.Empresa  AS [text()] FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n and Ejercicio=@ej GROUP BY Empresa FOR XML PATH ('')), 2,1000) [Empresas],SUM(Horas) as HRS FROM Registro r inner join LogIn li on r.Id_Empleado = li.Id_usuario where li.Nombre=@n  and Ejercicio=@ej GROUP BY li.Nombre";

                SqlCommand sqlcmd = new SqlCommand(consulta, sqlConexion);
                sqlcmd.Parameters.AddWithValue("ej", ej);
                sqlcmd.Parameters.AddWithValue("n", name);
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

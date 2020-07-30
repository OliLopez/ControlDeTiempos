using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace ControlDeTiempos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        //Inicio de codigo para loguear usuario
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-RH8U25N\\SQLEXPRESS;Initial Catalog=ControlTiempos;Integrated Security=True");
 
        public void logear(string usuario, string contrasena)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_usuario FROM LogIn WHERE Usuario= @usuario AND Contra = @pas", conexion);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if(dt.Rows[0][1].ToString()=="Admin")
                    {
                        new Administrador().Show();
                    }
                    else if(dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new Usuario(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        //Fin de codigo para loguear usuarios

        //Inicio de codigo para diseño
        //para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void txtNombreUsuario_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.Clear();
            txtNombreUsuario.ForeColor = Color.FromArgb(0, 0, 0);
            txtContraseña.ForeColor = Color.DarkSlateGray;
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtContraseña.PasswordChar = '*';
            txtContraseña.ForeColor=Color.FromArgb(0, 0, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.White;
        }
        //Fin de codigo para diseño

        //Validaciones de campos
        int validacionInicio()
        {
            if (!(txtNombreUsuario.Text.All(Char.IsLetter)) || (txtNombreUsuario.Text == ""))
            {
                return 1;
            }
            else
            {
                if (txtContraseña.Text == "" || txtContraseña.Text == "Contraseña")
                {
                    return 2;
                }
                else
                {
                    //no hay ningun error
                    return 0;
                }

            }
        }
        //Desarrollo del boton iniciar sesion
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            switch(validacionInicio())
            {
                case 0:
                    {
                        //no hay ningun error
                        errorProviderUsername.SetError(panel1, "");
                        logear(this.txtNombreUsuario.Text, this.txtContraseña.Text);
                        break;
                    }

                case 1:
                    {
                        errorProviderUsername.SetError(panel1, "Nombre de usuario invalido");
                        break;
                    }

                case 2:
                    {
                        errorProviderUsername.SetError(panel1, "Debe introducir una contraseña");
                        break;
                    }
            }
        }
        //Desarrollo del boton iniciar sesion
        //Fin Validaciones de campos
    }
}

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

namespace ControlDeTiempos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            switch(validacionInicio())
            {
                case 0:
                    {
                        //no hay ningun error
                        errorProviderUsername.SetError(panel1, "");
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("validaciones basicas completas ","Datos correctos", buttons);
                        break;
                    }

                case 1:
                    {
                        errorProviderUsername.SetError(panel1, "Nombre de usuario invalido, ingresar solo letras ");
                        break;
                    }

                case 2:
                    {
                        errorProviderUsername.SetError(panel1, "debe introducir una contraseña");
                        break;
                    }
            }
        }
        //Fin Validaciones de campos
    }
}

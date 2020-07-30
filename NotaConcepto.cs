using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeTiempos
{
    public partial class NotaConcepto : Form
    {
        public delegate void pasar(string concepto, string comentario);
        public event pasar pasado;
        public NotaConcepto(string concepto, string comentario)
        {
            InitializeComponent();
            //aqui le paso lo que llevaba del combobox del usuario
            txtConcepto.Text = concepto;
            txtComentario.Text = comentario;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            pasado(txtConcepto.Text,txtComentario.Text);
            Usuario enviar = new Usuario(txtConcepto.Text, txtComentario.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

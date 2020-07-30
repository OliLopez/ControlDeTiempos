using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeTiempos
{
    class Limpiar
    {
        public void BorrarCampos(Panel panel)
        {
            foreach(var txt in panel.Controls)
            {
                if(txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = -1;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos
{
    public partial class loginInventario : Form
    {
        public loginInventario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ladoIzquierdo.Left == 567)
            {
                ladoDerecho.Visible = false;
                ladoDerecho.Left = 567;

                ladoIzquierdo.Visible = false;
                ladoIzquierdo.Left = 266;
                ladoIzquierdo.Visible = true;
                ladoIzquierdo.Refresh();

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (ladoDerecho.Left == 567)
            {
                ladoIzquierdo.Visible = false;
                ladoIzquierdo.Left = 567;

                ladoDerecho.Visible = true;
                ladoDerecho.Left = 266;
                ladoDerecho.Visible = true;
                ladoDerecho.Refresh();

            }
        }
    }
}

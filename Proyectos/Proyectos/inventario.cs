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
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {}

        private void btnIngresa_Click(object sender, EventArgs e)
        { }

        private void btnIngresar_Click(object sender, EventArgs e)
        {}

        private void btnRegistrar_Click(object sender, EventArgs e)
        {      
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (ladoIzquierdo.Left == 598)
            {
                ladoDerecho.Visible = false;
                ladoDerecho.Left = 598;

                ladoIzquierdo.Visible = false;
                ladoIzquierdo.Left = 278;
                ladoIzquierdo.Visible = true;
                ladoIzquierdo.Refresh();

            }

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (ladoDerecho.Left == 598)
            {
                ladoIzquierdo.Visible = false;
                ladoIzquierdo.Left = 598;

                ladoDerecho.Visible = true;
                ladoDerecho.Left = 278;
                ladoDerecho.Visible = true;
                ladoDerecho.Refresh();

            }

        }
    }
}

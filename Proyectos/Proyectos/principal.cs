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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            entrada frmEntrada = new entrada();
            frmEntrada.Show();
            Close();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Salida frmSalida = new Salida();
            frmSalida.Show();

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            InventarioMenu frmInventario = new InventarioMenu();
            frmInventario.Show();
        }
    }
}

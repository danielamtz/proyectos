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
    public partial class Salida : Form
    {
        public Salida()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            principal frmPrincipal = new principal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}

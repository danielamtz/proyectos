﻿using System;
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
    public partial class InventarioMenu : Form
    {
        public InventarioMenu()
        {
            InitializeComponent();
        }

        private void btnAgregarPro_Click(object sender, EventArgs e)
        {
            Productos frmProductos = new Productos();
            frmProductos.Show();
        }
    }
}
namespace Proyectos
{
    partial class principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.btnEntrada = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalida = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnInventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEntrada.BackColor = System.Drawing.Color.DimGray;
            this.btnEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrada.BorderRadius = 7;
            this.btnEntrada.ButtonText = "Entrada productos";
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.DisabledColor = System.Drawing.Color.Gray;
            this.btnEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEntrada.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEntrada.Iconimage")));
            this.btnEntrada.Iconimage_right = null;
            this.btnEntrada.Iconimage_right_Selected = null;
            this.btnEntrada.Iconimage_Selected = null;
            this.btnEntrada.IconMarginLeft = 0;
            this.btnEntrada.IconMarginRight = 0;
            this.btnEntrada.IconRightVisible = true;
            this.btnEntrada.IconRightZoom = 0D;
            this.btnEntrada.IconVisible = true;
            this.btnEntrada.IconZoom = 90D;
            this.btnEntrada.IsTab = false;
            this.btnEntrada.Location = new System.Drawing.Point(213, 141);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEntrada.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEntrada.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEntrada.selected = false;
            this.btnEntrada.Size = new System.Drawing.Size(152, 74);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada productos";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrada.Textcolor = System.Drawing.Color.White;
            this.btnEntrada.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalida.BorderRadius = 7;
            this.btnSalida.ButtonText = "Salida productos";
            this.btnSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalida.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalida.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalida.Iconimage")));
            this.btnSalida.Iconimage_right = null;
            this.btnSalida.Iconimage_right_Selected = null;
            this.btnSalida.Iconimage_Selected = null;
            this.btnSalida.IconMarginLeft = 0;
            this.btnSalida.IconMarginRight = 0;
            this.btnSalida.IconRightVisible = true;
            this.btnSalida.IconRightZoom = 0D;
            this.btnSalida.IconVisible = true;
            this.btnSalida.IconZoom = 90D;
            this.btnSalida.IsTab = false;
            this.btnSalida.Location = new System.Drawing.Point(373, 141);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalida.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSalida.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalida.selected = false;
            this.btnSalida.Size = new System.Drawing.Size(152, 74);
            this.btnSalida.TabIndex = 1;
            this.btnSalida.Text = "Salida productos";
            this.btnSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalida.Textcolor = System.Drawing.Color.White;
            this.btnSalida.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.PaleTurquoise;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowText;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.MenuText;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(200, 354);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // btnInventario
            // 
            this.btnInventario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventario.BorderRadius = 7;
            this.btnInventario.ButtonText = "Inventario";
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInventario.Iconimage")));
            this.btnInventario.Iconimage_right = null;
            this.btnInventario.Iconimage_right_Selected = null;
            this.btnInventario.Iconimage_Selected = null;
            this.btnInventario.IconMarginLeft = 0;
            this.btnInventario.IconMarginRight = 0;
            this.btnInventario.IconRightVisible = true;
            this.btnInventario.IconRightZoom = 0D;
            this.btnInventario.IconVisible = true;
            this.btnInventario.IconZoom = 90D;
            this.btnInventario.IsTab = false;
            this.btnInventario.Location = new System.Drawing.Point(533, 141);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInventario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInventario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventario.selected = false;
            this.btnInventario.Size = new System.Drawing.Size(152, 74);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInventario.Textcolor = System.Drawing.Color.White;
            this.btnInventario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 354);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "principal";
            this.Text = "principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnEntrada;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalida;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventario;
    }
}
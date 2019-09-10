using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase_06.Entidades;

namespace Clase_06.WindowsForms
{
    public partial class Form1 : Form
    {
        Paleta miPaleta;

        

        public Form1()
        {
            InitializeComponent();

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.Visible = false; 
            this.IsMdiContainer = true; // indicar que el formulario principal va a ser contenedor de otros formularios mas
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miPaleta = 5;
            this.groupBox1.Visible = true;
            this.paletaToolStripMenuItem.Enabled = false;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmTempera(); // crear un nuevo formulario por cada paleta
            frm.MdiParent = this; // frm sera parte del formulario principal o contenedor
            
            frm.Show(); // mostrar ese formulario
            
           // this.miPaleta += frm.g
        }
    }
}

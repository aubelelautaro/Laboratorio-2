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

            this.WindowState = FormWindowState.Maximized;
            this.groupBoxPaleta.Visible = false; 
            this.IsMdiContainer = true; // indicar que el formulario principal va a ser contenedor de otros formularios mas
            this.groupBoxPaleta.Visible = false; 
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lstPaleta.Items.Clear(); // limpio list box
            
            this.miPaleta = 5; // crear una paleta de 5 pinturas
            this.groupBoxPaleta.Visible = true;
            this.paletaToolStripMenuItem.Enabled = false;
            this.DialogResult = DialogResult.Yes;
          //  this.paletaToolStripMenuItem.Visible = true;
           /* this.temperaToolStripMenuItem.Visible = true;
            this.temperaToolStripMenuItem.Enabled = true;*/

           
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            switch (this.DialogResult)
            {
                case DialogResult.Yes:

                    FrmTempera frm = new FrmTempera(); // crear un nuevo formulario por cada paleta
                                                       //      frm.MdiParent = this; // frm (El formulario de la tempera) sera parte del formulario principal o contenedor

                    frm.ShowDialog(); // mostrar ese formulario, no se aplica el frm.MdiParent
                    this.groupBoxPaleta.Visible = true;

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        this.miPaleta += frm.MiTempera;
                        lstPaleta.Items.Add((string)this.miPaleta[this.miPaleta | frm.MiTempera]); // corregir cuando muestra cuando agrega pero no cuando quita
                    }

                    break;

                default:
                    MessageBox.Show("Debe crear una paleta primero", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }

        }

        private void btnAgregarTempera_Click(object sender, EventArgs e)
        {
            this.temperaToolStripMenuItem_Click(sender, e);
        }

        private void btnQuitarTempera_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera();
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                lstPaleta.Items.Add((string)this.miPaleta[this.miPaleta | frm.MiTempera]); 
                miPaleta -= frm.MiTempera; 
            }
            else
            {
                MessageBox.Show("No se ha borrado ninguna tempera");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = lstPaleta.SelectedIndex;
         //   MessageBox.Show(this.miPaleta[indice]);
            FrmTempera frm = new FrmTempera(this.miPaleta[indice]);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                lstPaleta.Items.Clear();
                lstPaleta.Items.Add((string)this.miPaleta[this.miPaleta | frm.MiTempera]);
                miPaleta[indice] = frm.MiTempera;
            }
        }
    }
}

#region Using Directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase_04.Entidades;
#endregion

namespace Clase_04.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            string input1 = this.txtEntero.Text;
            string input2 = this.txtFecha.Text;
            string cadena = this.txtCadena.Text;

            DateTime fecha;
            int entero;

            if(int.TryParse(input1, out entero) && DateTime.TryParse(input2, out fecha) && !string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show($"Entero --> {entero} Cadena --> {cadena} Fecha --> {fecha}");
                lstLista.Items.Add($"Entero --> {entero}  Cadena --> {cadena} Fecha --> {fecha}");
                /* listbox.items.add() introducir texto en una listbox */
            }
            else
            {
                MessageBox.Show("EL FORMATO INGRESADO NO ES CORRECTO ! ! ");
            }  
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.txtCadena.Text = "";
            this.txtEntero.Text = "";
            this.txtFecha.Text = "";
            lstLista.Items.Clear(); 
        }

        private void BtnAzul_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRojo_Click(object sender, EventArgs e)
        {
           
        }
    }
}

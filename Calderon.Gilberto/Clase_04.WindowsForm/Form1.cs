using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_04.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int entero = int.Parse(this.txtEntero.Text);
            string cadena = this.txtCadena.Text;
            DateTime fecha = Convert.ToDateTime(this.txtFecha.Text);

            Clase_04.Entidades.Cosa obj = new Entidades.Cosa(cadena, fecha, entero);

            lstLista.Items.Add(obj.Mostrar());

            //MessageBox.Show(obj.Mostrar());

        }

        private void txtCadena_TextChanged(object sender, EventArgs e)
        {
            string cadena  = txtCadena.Text;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int entero = int.Parse(this.lblEntero.Text);
            string cadena = this.lblCadena.Text;
            DateTime fecha = Convert.ToDateTime(this.lblFecha.Text);

            Clase_04.Entidades.Cosa obj = new Entidades.Cosa(cadena, fecha, entero);

            //this.lstLista.Items.Add = obj.Mostrar();
        }
    }
}

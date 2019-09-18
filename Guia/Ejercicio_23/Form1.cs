using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvertEuro_Click(object sender, EventArgs e)
        {
            double entrada;

            if(double.TryParse(this.txtEuro.Text, out entrada))
            {
                Euro numero = new Euro(entrada);
                this.txtEuroADolar.Text = (((Dolar)numero).GetCantidad()).ToString();
                this.txtEuroAEuro.Text = numero.GetCantidad().ToString();
                this.txtEuroAPesos.Text = (((Pesos)numero).GetCantidad()).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese solo numeros!!");
                this.txtEuro.Focus();
            }
        }

        private void BtnConvertDolar_Click(object sender, EventArgs e)
        {
            double entrada;

            if(double.TryParse(this.txtDolar.Text, out entrada))
            {
                Dolar numero = new Dolar(entrada);
                this.txtDolarADolar.Text = numero.GetCantidad().ToString();
                this.txtDolarAEuro.Text = ((Euro)numero).GetCantidad().ToString();
                this.txtDolarAPesos.Text = ((Pesos)numero).GetCantidad().ToString();
          
            }
            else
            {
                MessageBox.Show("Ingrese solo numeros!!");
                this.txtDolar.Focus();
            }
        }

        private void BtnConvertPesos_Click(object sender, EventArgs e)
        {
            double entrada;

            if(double.TryParse(this.txtPesos.Text, out entrada))
            {
                Pesos numero = new Pesos(entrada);
                this.txtPesosADolar.Text = ((Dolar)numero).GetCantidad().ToString();
                this.txtPesosAEuro.Text = ((Euro)numero).GetCantidad().ToString();
                this.txtPesosAPesos.Text = numero.GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("Ingrese solo numeros!!");
                this.txtPesos.Focus();
            }
        }
    }
}

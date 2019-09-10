using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnidadesDeTemperatura;

namespace Ejercicio_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            float entrada;

            if(float.TryParse(this.txtFahrenheit.Text, out entrada))
            {
                Fahrenheit tempe = new Fahrenheit(entrada);
                this.txtFahrenheitACelsius.Text = ((Celsius)tempe).GetTemperatura().ToString();
                this.txtFahrenheitAFahrenheit.Text = tempe.GetTemperatura().ToString();
                this.txtFahrenheitAKelvin.Text = ((Kelvin)tempe).GetTemperatura().ToString();
            }
            else
            {
                MessageBox.Show("Ingrese solo numeros!!!");
                this.txtFahrenheit.Focus();
            }
        }

        private void BtnConvetCelsius_Click(object sender, EventArgs e)
        {
            float entrada;

            if(float.TryParse(this.txtCelsius.Text, out entrada))
            {
                Celsius tempe = new Celsius(entrada);
                this.txtCelsiusAFahrenheit.Text = ((Fahrenheit)tempe).GetTemperatura().ToString();
                this.txtCelsiusACelsius.Text = tempe.GetTemperatura().ToString();
                this.txtCelsiusAKelvin.Text = ((Kelvin)tempe).GetTemperatura().ToString();
            }
            else
            {
                MessageBox.Show("Ingrese solo numero!!!");
                this.txtCelsius.Focus();
            }
        }

        private void BtnConvertKelvin_Click(object sender, EventArgs e)
        {
            float entrada;

            if(float.TryParse(this.txtKelvin.Text, out entrada))
            {
                Kelvin tempe = new Kelvin(entrada);
                this.txtKelvinACelsius.Text = ((Celsius)tempe).GetTemperatura().ToString();
                this.txtKelvinAKelvin.Text = tempe.GetTemperatura().ToString();
                this.txtKelvinAFahrenheit.Text = ((Fahrenheit)tempe).GetTemperatura().ToString();
            }
            else
            {
                MessageBox.Show("Ingrese solo numeros!!!");
                this.txtKelvin.Focus();
            }
        }
    }
}

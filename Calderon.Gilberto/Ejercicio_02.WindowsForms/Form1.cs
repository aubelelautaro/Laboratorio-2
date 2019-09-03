using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02.WindowsForms
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del boton calcular que permite ver el resultado de lo ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string input = this.txtEntrada.Text;
            double numero; // numero real
            
            if(double.TryParse(input, out numero))
            {
                MessageBox.Show($"El cuadrado de {numero} es {Math.Pow(numero, 2)} el cubo es {Math.Pow(numero, 3)}");
            }
            else
            {
                MessageBox.Show("El formato ingresado no es correcto!!!");
            }
              
        }
    }
}

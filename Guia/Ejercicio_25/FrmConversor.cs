using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_25.Entidades;

namespace Ejercicio_25
{
    public partial class FrmConversor : Form
    {
        public FrmConversor()
        {
            InitializeComponent();
            this.txtResultadoBin.Enabled = false;
            this.txtResultadoDec.Enabled = false;
        }

        private void BtnBinToDec_Click(object sender, EventArgs e)
        {
            string conversion = Conversor.BinarioDecimal((this.txtBinario.Text));
           if ( conversion== "Valor Invalido")
            {
                MessageBox.Show("Ingrese un numero binario");
            }
            else
            {
                this.txtResultadoDec.Text = conversion;
            }
        }

        private void BtnDecToBin_Click(object sender, EventArgs e)
        {
            double dec;
            if(Double.TryParse(this.txtDecimal.Text, out dec))
            {
                this.txtResultadoBin.Text = Conversor.DecimalBinario(dec);
            }
            else
            {
                MessageBox.Show("Ingrese un numero decimal");
            }
        }
    }
}

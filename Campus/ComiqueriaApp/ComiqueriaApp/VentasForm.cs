using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto producto;
        private Venta venta;

        public VentasForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.numericUpDownCantidad.Minimum = 1;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DialogResult = DialogResult.Yes;

        }

        public VentasForm(Producto producto):this()
        {
            this.producto = producto;
            this.lblPrecioFinal.Text = this.lblPrecioFinal.Text.Replace("X.XX",this.producto.Precio.ToString());
            this.lblDescripcion.Text = producto.Descripcion;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            
        }

    }
}

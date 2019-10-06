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
     
        public Producto Producto
        {
            get
            {
                return this.producto;
            }
        }

        public int Cantidad
        {
            get
            {
                return (int)this.numericUpDownCantidad.Value;
            }
        }

        public VentasForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
          
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DialogResult = DialogResult.Yes;

        }

        public VentasForm(Producto producto):this()
        {
            this.producto = producto;
            this.numericUpDownCantidad.Minimum = 1;
            this.lblPrecioFinalNumero.Text.Replace(" ", producto.Precio.ToString());
            this.lblDescripcion.Text = producto.Descripcion;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.lblPrecioFinalNumero.Text = ((double)this.numericUpDownCantidad.Value * this.producto.Precio).ToString();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            if ((int)this.numericUpDownCantidad.Value <= this.producto.Stock)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Supero el stock disponible", "Stock no suficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

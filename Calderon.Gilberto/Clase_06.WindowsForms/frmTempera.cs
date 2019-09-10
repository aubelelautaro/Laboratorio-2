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
    public partial class FrmTempera : Form
    {
        private Tempera tempe;

       // public Tempera MiTempera { get this.tempe; }

        public Tempera GetTempera()
        {
            return this.tempe;
        }

        public FrmTempera()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            foreach(ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                 this.cboColor.Items.Add(c);
            }
            this.cboColor.SelectedItem = ConsoleColor.Magenta;
         // this.cboColor.DropDownStyle = ComboBox.
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (!String.IsNullOrEmpty(this.txtMarca.Text) && int.TryParse(this.txtCantidad.Text, out cantidad))
            {
                tempe = new Tempera((ConsoleColor)this.cboColor.SelectedItem, this.txtMarca.Text, cantidad);
                MessageBox.Show((string)tempe);
            }
            else
            {
                MessageBox.Show("Los valores ingresados son invalidos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

        /* Propiedades */
        public Tempera MiTempera
        {
            get
            {
                return this.tempe;
            }

            //set
            //{
            //    this.tempe = value;
            //}
        }   

        public FrmTempera()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // centrar la pantalla

            foreach(ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                 this.cboColor.Items.Add(c); // combobox.item.add() es para anadir elementos al combobox
            }

            this.cboColor.SelectedItem = ConsoleColor.Magenta; // Seleciona que este establecido por defecto
            this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList; // para evitar la interaccion del usuario con el combobox
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (!String.IsNullOrEmpty(this.txtMarca.Text) && int.TryParse(this.txtCantidad.Text, out cantidad))
            {
                tempe = new Tempera((ConsoleColor)this.cboColor.SelectedItem, this.txtMarca.Text, cantidad);
                MessageBox.Show((string)tempe); // muestro el obj tempera creado
                this.DialogResult = DialogResult.OK;
                this.Close(); // cerrar la ventana
            }
            else
            {
                MessageBox.Show("Los valores ingresados son invalidos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();  
        }
    }
}

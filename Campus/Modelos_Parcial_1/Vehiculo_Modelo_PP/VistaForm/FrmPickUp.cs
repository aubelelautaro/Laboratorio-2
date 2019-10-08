using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
namespace VistaForm
{
    public partial class FrmPickUp : Form
    {
        private PickUp pickUp;

        public FrmPickUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtModelo.Text) && !String.IsNullOrEmpty(txtPatente.Text))
            {
                pickUp = new PickUp(txtPatente.Text, txtModelo.Text);
                MessageBox.Show($"{pickUp.ConsultarDatos()}");
            }
            else
            {
                MessageBox.Show("Los campos estan vacios");
            }
        }
    }
}

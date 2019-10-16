using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaWindowsForms
{
    public partial class FrmLlamada : Form
    {
        protected Llamada miLlamada;

        public Llamada MiLlamada
        {
            get
            {
                return this.miLlamada;
            }
        }

       
        public FrmLlamada()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

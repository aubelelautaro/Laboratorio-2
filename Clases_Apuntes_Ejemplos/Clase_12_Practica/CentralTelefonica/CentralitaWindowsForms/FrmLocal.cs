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
    public partial class FrmLocal : FrmLlamada
    {
        //private Local local;

        //public Local LlamadaLocal
        //{
        //    get
        //    {
        //        return this.local;
        //    }
        //}

        public FrmLocal()
        {
            InitializeComponent();
        }

        //private void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    float duracion;
        //    float costo;
        //    if (float.TryParse(this.txtDuracion.Text, out duracion) && !string.IsNullOrEmpty(this.txtNumeroDestino.Text)
        //        && !string.IsNullOrEmpty(this.txtNumeroOrigen.Text) && float.TryParse(this.txtCosto.Text, out costo))
        //    {
        //        local = new Local(this.txtNumeroOrigen.Text, duracion, this.txtNumeroDestino.Text, costo);
        //        this.DialogResult = DialogResult.OK;
        //    }
        //    else
        //    {
        //        MessageBox.Show("El formato de los datos ingresados son incorrectos!!!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        this.DialogResult = DialogResult.No;
        //    }
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    this.DialogResult = DialogResult.Cancel;
        //    this.Close();
        //}

           /* CORRECION */
        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            float duracion = float.Parse(this.txtDuracion.Text);
            float costo = float.Parse(this.txtCosto.Text);
            base.miLlamada = new Local(this.txtNumeroOrigen.Text, duracion, this.txtNumeroDestino.Text, costo);
            base.btnAceptar_Click(sender, e);
        }
    }
}

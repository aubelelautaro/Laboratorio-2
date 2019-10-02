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
    public partial class FrmProvincial : FrmLlamada
    {
        //Provincial provincial;

        //public Provincial LlamadaProvincial
        //{
        //    get
        //    {
        //        return this.provincial;
        //    }
        //}

        public FrmProvincial()
        {
            InitializeComponent();
            this.cboFranja.DataSource = Enum.GetValues(typeof(Franja));
        }

        //protected  void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    float duracion;

        //    if (float.TryParse(this.txtDuracion.Text, out duracion) && !string.IsNullOrEmpty(this.txtNumeroDestino.Text)
        //                  && !string.IsNullOrEmpty(this.txtNumeroOrigen.Text))
        //    {
        //        provincial = new Provincial(this.txtNumeroOrigen.Text, (Franja)this.cboFranja.SelectedItem, duracion, this.txtNumeroDestino.Text);
        //        this.DialogResult = DialogResult.OK;
        //    }
        //    else
        //    {
        //        MessageBox.Show("El formato de los datos ingresados son incorrectos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        this.DialogResult = DialogResult.No;
        //    }
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    this.DialogResult = DialogResult.Cancel;
        //    this.Close(); 
        //}

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            float duracion = float.Parse(this.txtDuracion.Text);
            this.miLlamada = new Provincial(this.txtNumeroOrigen.Text, (Franja)this.cboFranja.SelectedItem, duracion, this.txtNumeroDestino.Text);
            base.btnAceptar_Click(sender, e);
        }
    }
}

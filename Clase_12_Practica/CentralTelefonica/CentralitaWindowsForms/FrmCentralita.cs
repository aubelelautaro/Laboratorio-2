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
    public partial class FrmCentralita : Form
    {
        Centralita centralita;

        public FrmCentralita()
        {
            InitializeComponent();
            this.centralita = new Centralita();
            this.cboOrdenamiento.SelectedItem = "";
           // this.cboOrdenamiento.SelectedIndex = 0;
        }

        private void btnLlamadaLocal_Click(object sender, EventArgs e)
        {
            FrmLocal frm = new FrmLocal();
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                centralita += frm.MiLlamada;
                this.ActualizarLista();
            }

        }

        private void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            foreach(Llamada value in this.centralita.Llamadas)
            {
                this.lstVisor.Items.Add(value.ToString());
            }
        }

        private void btnLlamadaProvincial_Click(object sender, EventArgs e)
        {
            FrmProvincial frm = new FrmProvincial();
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                this.centralita += frm.MiLlamada;
                this.ActualizarLista();
            }
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cboOrdenamiento.SelectedIndex == 0)
            {
                this.centralita.Llamadas.Sort(Llamada.OrdenarPorDuracion);
            }
            else
            {
                this.centralita.Llamadas.Sort(Llamada.OrdenarPorDuracionDesc);
            }
            this.ActualizarLista();
        }
    }
}

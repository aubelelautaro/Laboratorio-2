using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        private List<Persona> lista;

        public List<Persona> Lista
        {
            get
            {
                return this.lista;
            }
        }

        public frmVisorPersona(List<Persona> lista)
        {
            InitializeComponent();
            this.lista = lista;
            this.ActualizarLista();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                this.lista.Add(frm.Persona);
                this.ActualizarLista();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(lstVisor.SelectedIndex >=0)
            {
                Persona per = lista[index];
                frmPersona frm = new frmPersona(per);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    this.lista.Remove(per);
                    this.lista.Add(frm.Persona);
                }
                this.ActualizarLista();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            int index = this.lstVisor.SelectedIndex;

            if(index >=0)
            {
                this.lista.Remove(lista[index]);
                this.ActualizarLista();
            }
            
        }

        private void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            foreach (Persona value in this.lista)
            {
                this.lstVisor.Items.Add(value.ToString());
            }
        }
    }
}

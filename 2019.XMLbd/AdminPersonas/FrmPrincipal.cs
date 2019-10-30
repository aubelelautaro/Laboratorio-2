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
using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            this.lista = new List<Persona>();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();

                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                XmlTextReader xmltxt = new XmlTextReader(openFileDialog1.FileName);

                
                this.lista = (List<Persona>)xml.Deserialize(xmltxt);

                xmltxt.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.saveFileDialog1.ShowDialog();

                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));

                XmlTextWriter xmltxt = new XmlTextWriter(saveFileDialog1.FileName, Encoding.UTF8);

                xml.Serialize(xmltxt, this.lista);

                xmltxt.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(lista);

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
            this.lista = frm.Lista;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);

                sql.Open();
                MessageBox.Show("EXITO!");
                SqlCommand comando = new SqlCommand();

                comando.Connection = sql;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]ROM[personas_bd].[dbo].[personas]";

                SqlDataReader dataReader = comando.ExecuteReader(); // no se puede hacer busquedas, solo va para adelante

                while (dataReader.Read() != false)
                {
                    MessageBox.Show(dataReader[0].ToString());
                    MessageBox.Show(dataReader[1].ToString());
                    MessageBox.Show(dataReader[2].ToString());
                }

                comando.Connection.Close();
                dataReader.Close();
                sql.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}

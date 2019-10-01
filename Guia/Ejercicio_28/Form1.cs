using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class btnCalcular : Form
    {
        Dictionary<string, int> dic;

        public btnCalcular()
        {
            InitializeComponent();
            dic = new Dictionary<string, int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("\n", dic));
            
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.ValidarTexto(this.richTextBox1);
            this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length;

            int cont = 0;
                                
            foreach (string value in this.richTextBox1.Text.Split(' '))
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (this.dic.ContainsKey(value))
                    {
                        dic[value] += 1; 
                    }
                    else
                    {
                        this.dic.Add(value, 1);
                    }
                    this.label1.Text = (++cont).ToString();

                }
            }
        }

        private string ValidarTexto(RichTextBox obj)
        {
            string aux = string.Empty;
            char[] array = obj.Text.ToCharArray();
            foreach (char value in array)
            {
                if ((value >= 65 && value <= 90) || (value >= 97 && value <= 122) || value == 32)
                {
                    aux += value;
                }
            }
            return aux;
        }

    }
}

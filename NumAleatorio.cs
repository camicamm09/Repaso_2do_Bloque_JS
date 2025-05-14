using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_2do_Bloque_JS
{
    public partial class NumAleatorio : Form
    {
        int aleatorio = 0;
        Random rand = new Random();
        public NumAleatorio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNummax.Text, out int nunmax))
            {

                if (nunmax < 1)
                {
                    MessageBox.Show("Ingrese un numero positivo");
                }
                else
                {
                    aleatorio = rand.Next(1, nunmax);
                    MessageBox.Show($"Numero:{aleatorio}");
                }
            }


            else
            {
                MessageBox.Show("Ingrese un numero a");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaSemana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String dia = textBox1.Text;
            switch (Convert.ToInt32(dia))
            {
                case 1:
                    textBox2.Text = "Lunes";
                    break;
                case 2:
                    textBox2.Text = "Martes";
                    break;
                case 3:
                    textBox2.Text = "Miercoles";
                    break;
                case 4:
                    textBox2.Text = "Jueves";
                    break;
                case 5:
                    textBox2.Text = "Viernes";
                    break;
                case 6:
                    textBox2.Text = "Sabado";
                    break;
                case 7:
                    textBox2.Text = "Domingo";
                    break;
                default:
                    MessageBox.Show("Ingrese un numero valido (1-7)","Error");
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

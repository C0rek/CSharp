using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2_korek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Activar Bonificacion Hijos
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
        }


        // funcionamiento botones
        
        // Boton SALIR
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Boton CALCULAR
        private void button1_Click(object sender, EventArgs e)
        {
            int hijos = (int)(numericUpDown1.Value);
            int bonificacion = hijos * 20;
            
            String horastrabajadas = textBox1.Text;
            String preciohoras = textBox3.Text;
            if ((String.IsNullOrEmpty(textBox2.Text) || (String.IsNullOrEmpty(textBox4.Text))))
            {
                double SueldoBruto = Convert.ToInt32(horastrabajadas) * Convert.ToInt32(preciohoras);
                textBox5.Text = SueldoBruto.ToString();
            } else {
                String horasextras = textBox2.Text;
                String precioextras = textBox4.Text;

                double SueldoBruto = Convert.ToInt32(horastrabajadas) * Convert.ToInt32(preciohoras) + Convert.ToInt32(horasextras) * Convert.ToInt32(precioextras);
                double SueldoNeto = SueldoBruto + bonificacion;

                // muestro en las casillas el resultado
                textBox5.Text=SueldoBruto.ToString();
                textBox6.Text=SueldoNeto.ToString();
                textBox7.Text=bonificacion.ToString();
            }
        }

        // Boton NUEVO
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            numericUpDown1.Value = 0;
        }
    }
}

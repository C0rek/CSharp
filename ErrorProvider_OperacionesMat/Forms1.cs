using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider_OperacionesMat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Error()        // Error por Vacio
        {
            bool vacio = false;
            if (String.IsNullOrEmpty(txtNumero1.Text) || String.IsNullOrEmpty(txtNumero2.Text))
            {
                errorProvider1.SetError(txtNumero1, "Ingrese un numero");
                errorProvider1.SetError(txtNumero2, "Ingrese un numero");
                vacio = true;
            }
            else
            {
                bool error = false;
                foreach (char caracter in this.txtNumero1.Text)
                {
                    if (char.IsLetter(caracter))
                    {
                        error = true;
                        break;
                    }
                }
                if (error)
                {
                    errorProvider1.SetError(txtNumero1, "No se permiten letras");
                    vacio = true;
                }
                else
                {
                    errorProvider1.Clear();
                    vacio = false;
                }
            }
            return vacio;
        }

        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Error();
            if (Error() == false)
            {
                double resultado = 0;
                String num1 = txtNumero1.Text;
                String num2 = txtNumero2.Text;
                resultado = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                txtResultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Error();
            if (Error() == false)
            {
                double resultado = 0;
                String num1 = txtNumero1.Text;
                String num2 = txtNumero2.Text;
                resultado = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                txtResultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Error();
            if (Error() == false)
            {
                double resultado = 0;
                String num1 = txtNumero1.Text;
                String num2 = txtNumero2.Text;
                resultado = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                txtResultado.Text = Convert.ToString(resultado);
                 
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Error();
            if (Error() == false)
            {
                double resultado = 0;
                String num1 = txtNumero1.Text;
                String num2 = txtNumero2.Text;
                if (Convert.ToDouble(num2)==0)
                {
                    errorProvider1.SetError(txtNumero2, "No divisible por 0");
                }
                else
                {
                    resultado = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                    txtResultado.Text = Convert.ToString(resultado);
                } 
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            foreach (char caracter in this.txtNumero1.Text)
            {
                if (char.IsSymbol(caracter) || (char.IsPunctuation(caracter)))
                {
                    if (Convert.ToChar(caracter) == 44)         // 44 es el ASCII de la coma (,) 
                    {
                        error = false;
                        break;
                    }
                    error = true;
                    break;
                }
            }

            if (error)
            {
                errorProvider1.SetError(txtNumero1, "No se permiten simbolos excepto (,)");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            foreach (char caracter in this.txtNumero2.Text)
            {
                if (char.IsSymbol(caracter) || (char.IsPunctuation(caracter)))
                {
                    if (Convert.ToChar(caracter) == 44)
                    {
                        error = false;
                        break;
                    }
                    error = true;
                    break;
                }
            }

            if (error)
            {
                errorProvider1.SetError(txtNumero2, "No se permiten simbolos excepto (,)");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}

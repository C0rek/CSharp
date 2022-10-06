using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre");
            }
            else
            {
                bool error = false;
                foreach (char caracter in this.txtNombre.Text)
                {
                    if (char.IsDigit(caracter))
                    {
                        error = true;
                        break;
                    }
                }
                if (error)
                {
                    errorProvider1.SetError(txtNombre, "No se permiten digitos");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            foreach (char caracter in this.txtNombre.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtNombre, "No se permiten digitos");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            foreach (char caracter in this.txtEdad.Text)
            {
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtEdad, "No se permiten letras");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            foreach (char caracter in this.txtSalario.Text)
            {
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                errorProvider1.SetError(txtSalario, "No se permiten letras");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtSalario.Text = "";
            txtDescripcion.Text = "";
        }
    }           
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool secuencia = true, punto=true;
        string operacion, borrado;
            
        double numero1,numero2, resultado;

        //numero de la calculadora
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtbPantalla.Text = "";
                txtbPantalla.Text = "1";
                secuencia = false;
            }
            else
            { txtbPantalla.Text = txtbPantalla.Text + "1";
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtbPantalla.Text = "";
                txtbPantalla.Text = "2";
                secuencia = false;
            }
            else
            {
                txtbPantalla.Text = txtbPantalla.Text + "2";
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtbPantalla.Text = "";
                txtbPantalla.Text = "3";
                secuencia = false;
            }
            else
            {
                txtbPantalla.Text = txtbPantalla.Text + "3";
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtbPantalla.Text = "";
                txtbPantalla.Text = "4";
                secuencia = false;
            }
            else
            {
                txtbPantalla.Text = txtbPantalla.Text + "4";
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtbPantalla.Text = "";
                txtbPantalla.Text = "5";
                secuencia = false;
            }
            else
            {
                txtbPantalla.Text = txtbPantalla.Text + "5";
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtbPantalla.Text = "";
                txtbPantalla.Text = "6";
                secuencia = false;
            }
            else
            {
                txtbPantalla.Text = txtbPantalla.Text + "6";
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtbPantalla.Text = "";
                txtbPantalla.Text = "7";
                secuencia = false;
            }
            else
            {
                txtbPantalla.Text = txtbPantalla.Text + "7";
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtbPantalla.Text = "";
                txtbPantalla.Text = "8";
                secuencia = false;
            }
            else
            {
                txtbPantalla.Text = txtbPantalla.Text + "8";
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtbPantalla.Text = "";
                txtbPantalla.Text = "9";
                secuencia = false;
            }
            else
            {
                txtbPantalla.Text = txtbPantalla.Text + "9";
            }
        }

        private void btMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1= double.Parse(txtbPantalla.Text);
            secuencia=true;
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = double.Parse(txtbPantalla.Text);
            secuencia = true;
        }

        private void btPor_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = double.Parse(txtbPantalla.Text);
            secuencia = true;
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(txtbPantalla.Text);
            secuencia = true;
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(txtbPantalla.Text);
            if (operacion == "+")
            { resultado = numero1 + numero2;
            txtbPantalla.Text = resultado.ToString();
            secuencia = true;
            }
            if (operacion == "-")
            {
                resultado = numero1 - numero2;
                txtbPantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                resultado = numero1 * numero2;
                txtbPantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "/")
            {
                resultado = numero1 / numero2;
                txtbPantalla.Text = resultado.ToString();
                secuencia = true;
            }
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            if (punto == true)
            {
                txtbPantalla.Text = txtbPantalla.Text + ",";
            }
            else
            {
                return;
            }

      }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (txtbPantalla.Text == "0")
            {
                return;
            }
            else { txtbPantalla.Text = txtbPantalla.Text + "0"; }

        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtbPantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            secuencia = true;

        }

        private void btRetroceso_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = txtbPantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            txtbPantalla.Text = borrado;


            if (txtbPantalla.Text == "")
            {
                txtbPantalla.Text = "0";
                secuencia = true;
            }
            if (txtbPantalla.Text == "-")
            {
                txtbPantalla.Text = "0";
                secuencia = true;
                    
            }
        }
        
    }
}

using System;
using System.Configuration;

namespace elpepe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double valor1;
        private double valor2;

        private double resultado;
        private int operacion;

        private void num0_Click(object sender, EventArgs e)
        {
            //numero 0
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            //numero 1
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            //numero 2
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            //numero 3
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            //numero 4
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            //numero 5
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            //numero 6
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            //numero 7
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            //numero 8
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            //numero 9
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            //boton limpiar
            tbDisplay.Text = "";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            //boton igual
            valor2 = Convert.ToDouble(tbDisplay.Text);
            switch (operacion)
            {
                case 1: resultado = valor1 + valor2; break;
                case 2: resultado = valor1 - valor2; break;
                case 3: resultado = valor1 * valor2; break;
                case 4: resultado = valor1 / valor2; break;

            }
            tbDisplay.Text = resultado.ToString();
        }

        private void mas_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void menos_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }
    }
}
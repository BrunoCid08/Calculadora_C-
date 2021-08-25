using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_CSharp
{
    public partial class Interface : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "9";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += ".";
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
            txt_resultado.Text = "";
            operacao = "SOMA";
            lbl_operacao.Text = "+";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                txt_resultado.Text = Convert.ToString(valor1 + valor2);
            } 
            else if(operacao == "SUB")
            {
                txt_resultado.Text = Convert.ToString(valor1 - valor2);
            } 
            else if(operacao == "MULT")
            {
                txt_resultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txt_resultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
            txt_resultado.Text = "";
            operacao = "SUB";
            lbl_operacao.Text = "-";
        }

        private void btn_vezes_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
            txt_resultado.Text = "";
            operacao = "MULT";
            lbl_operacao.Text = "×";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
            txt_resultado.Text = "";
            operacao = "DIV";
            lbl_operacao.Text = "÷";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
        }
    }
}

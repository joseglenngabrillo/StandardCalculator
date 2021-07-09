using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_click = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if ((output.Text == "0")||(operation_click))
                output.Clear();

            operation_click = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if(!output.Text.Contains("."))
                    output.Text = output.Text + b.Text;
            }
            else
                output.Text = output.Text + b.Text;
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                btn_equal.PerformClick();
                operation_click = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(output.Text);
                operation_click = true;
                equation.Text = value + " " + operation;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    output.Text = (value + Double.Parse(output.Text)).ToString();
                    break;
                case "-":
                    output.Text = (value - Double.Parse(output.Text)).ToString();
                    break;
                case "/":
                    output.Text = (value / Double.Parse(output.Text)).ToString();
                    break;
                case "x":
                    output.Text = (value * Double.Parse(output.Text)).ToString();
                    break;
            }// end

            value = Int32.Parse(output.Text);
            operation = "";
        }

            private void btnCE_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            output.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int length = output.TextLength - 1;
            string text = output.Text;
            output.Clear();
            for (int i = 0; i < length; i++)
                output.Text = output.Text + text[i];
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case "+":
                    btn_plus.PerformClick();
                    break;
                case "-":
                    btn_minus.PerformClick();
                    break;
                case "/":
                    btn_divide.PerformClick();
                    break;
                case "x":
                    btn_times.PerformClick();
                    break;
                case "=":
                    btn_equal.PerformClick();
                    break;
                case "ENTER":
                    btn_equal.PerformClick();
                    break;
                default:
                    break;
            }// end
        }
    }
}

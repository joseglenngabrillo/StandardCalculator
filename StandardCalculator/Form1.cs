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
            if (output.Text == "0")
                output.Clear();

            operation_click = false;
            Button b = (Button)sender;
            output.Text = output.Text + b.Text;
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(output.Text);
            operation_click = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
 
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            output.Text = "0";
            value = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int length = output.TextLength - 1;
            string text = output.Text;
            output.Clear();
            for (int i = 0; i < length; i++)
                output.Text = output.Text + text[i];
        }
    }
}

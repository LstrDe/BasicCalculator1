using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCompute_Click(object sender, EventArgs e)
        {
            float num1 = (float)Convert.ToDouble(Num1.Text);
            float num2 = (float)Convert.ToDouble(Num2.Text);

            if(cbOperator.Text == "+")
            {
                float total = BasicComputation.getAddition(num1, num2);
                string totals = total.ToString();
                totallbl.Text = totals;
            }
            else if(cbOperator.Text == "-")
            {
                float total = BasicComputation.getSubtraction(num1, num2);
                string totals = total.ToString();
                totallbl.Text = totals;
            }
            else if (cbOperator.Text == "*")
            {
                float total = BasicComputation.getMultiplication(num1, num2);
                string totals = total.ToString();
                totallbl.Text = totals;
            }
            else if (cbOperator.Text == "/")
            {
                float total = BasicComputation.getDivision(num1, num2);
                string totals = total.ToString();
                totallbl.Text = totals;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

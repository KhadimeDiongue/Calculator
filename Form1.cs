using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();

        }
        //Calculation methods
        static int AddNumbers(int num1, int num2)
        {
            int sum;
            sum = num1 + num2;
            return sum;
        }
        static int minusNumbers(int num1, int num2)
        {
            int difference;
            difference = num1 - num2;
            return difference;
        }
        static int divideNumber(int num1, int num2)
        {
            double divide;
            divide = (double) num1 /num2;
            return (int)divide;
            
        }
        static int multiplyNumber(int num1, int num2)
        {
            int multiply;
            multiply = num1 * num2;
            return multiply;
        }
        
        //Mathematical operation buttons (Click actions)
        private void PlusButton_Click(object sender, EventArgs e)
        {
            int sum;
            sum = AddNumbers(int.Parse(NumberOneTextBox.Text), int.Parse(NumberTwoTextBox.Text));
            AnswerTextBox.Text = sum.ToString();

            progressBar1.Value = 100;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            int difference;
            difference = minusNumbers(int.Parse(NumberOneTextBox.Text), int.Parse(NumberTwoTextBox.Text));
            AnswerTextBox.Text = difference.ToString();

            progressBar1.Value = 100;

        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            int divide;
            divide = divideNumber(int.Parse(NumberOneTextBox.Text), int.Parse(NumberTwoTextBox.Text));
            AnswerTextBox.Text = divide.ToString();

            progressBar1.Value = 100;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            int multiply;
            multiply = multiplyNumber(int.Parse(NumberOneTextBox.Text), int.Parse(NumberTwoTextBox.Text));
            AnswerTextBox.Text = multiply.ToString();

            progressBar1.Value = 100;
        }

        //Clear Answer text box button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            AnswerTextBox.Text = "";
            NumberOneTextBox.Text = "";
            NumberTwoTextBox.Text = "";
            progressBar1.Value = 0;

            
        }

        
    }
}

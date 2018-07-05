using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Calculator_Better_Design
{
    public partial class Calculator : Form
    {
        Logic.Calculator calculator;
        private bool isNewNumberEntered = true;
        public string temp_History = "";

        public Calculator()
        {
            InitializeComponent();
            calculator = new Logic.Calculator();
        }


        private void Digit_Click(object sender, EventArgs e)
        {
            Button buttonPushed = (Button)sender;
            string buttonValue = buttonPushed.Tag.ToString();
            if (display.Text == "0" || isNewNumberEntered == true)
            {
                display.Text = buttonValue;
                isNewNumberEntered = false;
            }
            else
            {
                display.Text += buttonValue;
            }



        }
        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            calculator.Number_entered(Convert.ToDouble(display.Text));
            display.Text = calculator.Addition_entered();
            isNewNumberEntered = true;
            temp_History += display.Text + "+";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            calculator.Number_entered(Convert.ToDouble(display.Text));
            display.Text = calculator.Subtraction_entered();
            isNewNumberEntered = true;
            temp_History += display.Text + "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            calculator.Number_entered(Convert.ToDouble(display.Text));
            display.Text = calculator.Multiplication_entered();
            isNewNumberEntered = true;
            temp_History += display.Text + "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            calculator.Number_entered(Convert.ToDouble(display.Text));
            display.Text = calculator.Division_entered();
            isNewNumberEntered = true;
            temp_History += display.Text + "/";
        }

        private void square_root_Click(object sender, EventArgs e)
        {
            temp_History = calculator.Number_entered(Convert.ToDouble(display.Text));
            display.Text = calculator.Square_root_entered();
            isNewNumberEntered = true;
            history.Text += "√ " + temp_History + "=" + display.Text + "\n";
            temp_History = "";

        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            //calculator.Number_entered(Convert.ToDouble(display.Text));
            //display.Text = calculator.Reciprocal_entered();
            //isNewNumberEntered = true;
            //temp_History += display.Text;

            temp_History = calculator.Number_entered(Convert.ToDouble(display.Text));
            display.Text = calculator.Reciprocal_entered();
            isNewNumberEntered = true;
            history.Text += "1/" + temp_History + "=" + display.Text + "\n";
            temp_History = "";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            calculator.Number_entered(Convert.ToDouble(display.Text));
            temp_History += display.Text + "=";
            display.Text = calculator.Equals();
            temp_History += display.Text;
            history.Text += temp_History + "\n";
            temp_History = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = calculator.Clear_entered();
            calculator.pending_operation = null;
            isNewNumberEntered = true;
        }

        private void decimal_point_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";

        }
    }
}

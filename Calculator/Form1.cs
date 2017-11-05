using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        CALCULATOR calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new CALCULATOR();          //instantiate an object of CALCULATOR class
            calculator.clearEverything();           //initialize all values to 0
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonOneClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('1');
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonTwoClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('2');
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonThreeClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('3');
            display.Text = calculator.returnScreenValue();
        }

        private void onBttonFourClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('4');
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonFiveClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('5');
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonSixClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('6');
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonSevenClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('7');
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonEightClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('8');
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonNineClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('9');
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonZeroClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('0');
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonDecimalClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('.');
            display.Text = calculator.returnScreenValue();
        }

        private void onnButtonEqualClick(object sender, EventArgs e)
        {

        }

        private void onButtonAddClick(object sender, EventArgs e)
        {

        }

        private void onButtonMinusClick(object sender, EventArgs e)
        {

        }

        private void onButtonMultiplyClick(object sender, EventArgs e)
        {

        }

        private void onButtonDivideClick(object sender, EventArgs e)
        {

        }

        private void onButtonSqrtClick(object sender, EventArgs e)
        {

        }

        private void onButtonExponentClick(object sender, EventArgs e)
        {

        }

        private void onButtonClearClick(object sender, EventArgs e)
        {
            calculator.clear();
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonClearEverythingClick(object sender, EventArgs e)
        {
            calculator.clearEverything();
            display.Text = calculator.returnScreenValue();
        }

        private void onButtonPlusMinusClick(object sender, EventArgs e)
        {

        }

        private void onButtonInverseClick(object sender, EventArgs e)
        {

        }
    }
}

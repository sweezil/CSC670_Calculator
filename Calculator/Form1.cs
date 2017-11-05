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
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonOneClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('1');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonTwoClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('2');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonThreeClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('3');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onBttonFourClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('4');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonFiveClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('5');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonSixClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('6');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonSevenClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('7');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonEightClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('8');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonNineClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('9');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonZeroClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('0');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonDecimalClick(object sender, EventArgs e)
        {
            calculator.buildScreenValue('.');
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonAddClick(object sender, EventArgs e)
        {
            calculator.add();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonMinusClick(object sender, EventArgs e)
        {

            calculator.subtract();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonMultiplyClick(object sender, EventArgs e)
        {
            calculator.multiply();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonDivideClick(object sender, EventArgs e)
        {
            calculator.divide();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonSqrtClick(object sender, EventArgs e)
        {
            calculator.sqrt();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonExponentClick(object sender, EventArgs e)
        {
            calculator.exponent();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonClearClick(object sender, EventArgs e)
        {
            calculator.clear();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonClearEverythingClick(object sender, EventArgs e)
        {
            calculator.clearEverything();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonPlusMinusClick(object sender, EventArgs e)
        {
            calculator.plusMinus();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonInverseClick(object sender, EventArgs e)
        {
            calculator.inverse();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonEnterClick(object sender, EventArgs e)
        {
            calculator.enter();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonPopClick(object sender, EventArgs e)
        {
            calculator.pop();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void onButtonSwapClick(object sender, EventArgs e)
        {
            calculator.swap();
            display1.Text = calculator.returnScreenValue()[0];
            display2.Text = calculator.returnScreenValue()[1];
            display3.Text = calculator.returnScreenValue()[2];
            display4.Text = calculator.returnScreenValue()[3];
        }

        private void display4_TextChanged(object sender, EventArgs e)
        {

        }

        private void display3_TextChanged(object sender, EventArgs e)
        {

        }

        private void display2_TextChanged(object sender, EventArgs e)
        {

        }

        private void display1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

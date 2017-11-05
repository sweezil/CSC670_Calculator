using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CALCULATOR
    {
        enum CALCULATION_TYPE
        {
            add, 
            subtract,
            multiply,
            divide,
            exponent,
            none
        }

        private double accumulator;
        private String screenValue;
        private bool calculationOccurred;
        private CALCULATION_TYPE calculation;

        public String returnScreenValue() { return screenValue; }

        public void buildScreenValue(char c)
        {
            if (calculationOccurred)
            {
                calculationOccurred = false;
                accumulator = Convert.ToDouble(screenValue);
                screenValue = c.ToString();
            }
            else if (screenValue[0] == '0')
                screenValue = c.ToString();
            else
                screenValue += c.ToString();
        }

        public void clearEverything()
        {
            accumulator = 0;
            screenValue = "0";
            calculation = CALCULATION_TYPE.none;
            calculationOccurred = false;
        }

        public void clear()
        {
            if (screenValue.Length == 1)
                screenValue = "0";
            else
                screenValue = screenValue.Substring(0, screenValue.Length - 1);
        }
    }
}

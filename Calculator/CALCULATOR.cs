using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CALCULATOR
    {
        enum OPERATION_TYPE
        {
            none,
            swapOccurred,
            enterOccurred
        }
    
        private String[] screenValue = new String[4];
        private OPERATION_TYPE eventOccurred;

        public String[] returnScreenValue() { return screenValue; }

        public void buildScreenValue(char c)
        {
            if (eventOccurred == OPERATION_TYPE.enterOccurred)
            {
                eventOccurred = OPERATION_TYPE.none;
                screenValue[0] = c.ToString();
            }
            else if (eventOccurred == OPERATION_TYPE.swapOccurred)
            {
                eventOccurred = OPERATION_TYPE.none;
                screenValue[3] = screenValue[2];
                screenValue[2] = screenValue[1];
                screenValue[1] = screenValue[0];
                screenValue[0] = c.ToString();
            }
            else if (screenValue[0][0] == '0' && screenValue[0].Length == 1)
                screenValue[0] = c.ToString();
            else
                screenValue[0] += c.ToString();
        }

        public void clearEverything()
        {
            for (int i = 0; i < 4; ++i)
                screenValue[i] = "0";
            eventOccurred = OPERATION_TYPE.none;
        }

        public void clear()
        {
            if (screenValue[0].Length == 1 || eventOccurred == OPERATION_TYPE.enterOccurred)
                screenValue[0] = "0";
            else
                screenValue[0] = screenValue[0].Substring(0, screenValue[0].Length - 1);
        }

        public void pop()
        {
            screenValue[0] = screenValue[1];
            screenValue[1] = screenValue[2];
            screenValue[2] = screenValue[3];
            screenValue[3] = "0";
        }

        public void swap()
        {
            double temp = Convert.ToDouble(screenValue[0]);
            screenValue[0] = screenValue[1];
            screenValue[1] = temp.ToString();
            eventOccurred = OPERATION_TYPE.swapOccurred;
        }

        public void add()
        {
            screenValue[0] = (Convert.ToDouble(screenValue[1]) + Convert.ToDouble(screenValue[0])).ToString();
            screenValue[1] = screenValue[2];
            screenValue[2] = screenValue[3];
            screenValue[3] = "0";
            eventOccurred = OPERATION_TYPE.enterOccurred;
        }

        public void subtract()
        {
            screenValue[0] = (Convert.ToDouble(screenValue[1]) - Convert.ToDouble(screenValue[0])).ToString();
            screenValue[1] = screenValue[2];
            screenValue[2] = screenValue[3];
            screenValue[3] = "0";
            eventOccurred = OPERATION_TYPE.enterOccurred;
        }

        public void multiply()
        {
            screenValue[0] = (Convert.ToDouble(screenValue[1]) * Convert.ToDouble(screenValue[0])).ToString();
            screenValue[1] = screenValue[2];
            screenValue[2] = screenValue[3];
            screenValue[3] = "0";
            eventOccurred = OPERATION_TYPE.enterOccurred;
        }

        public void divide()
        {
            screenValue[0] = (Convert.ToDouble(screenValue[1]) / Convert.ToDouble(screenValue[0])).ToString();
            screenValue[1] = screenValue[2];
            screenValue[2] = screenValue[3];
            screenValue[3] = "0";
            eventOccurred = OPERATION_TYPE.enterOccurred;
        }

        public void exponent()
        {
            screenValue[0] = (Math.Pow(Convert.ToDouble(screenValue[1]), Convert.ToDouble(screenValue[0]))).ToString();
            screenValue[1] = screenValue[2];
            screenValue[2] = screenValue[3];
            screenValue[3] = "0";
            eventOccurred = OPERATION_TYPE.enterOccurred;
        }

        public void sqrt()
        {
            screenValue[0] = (Math.Sqrt(Convert.ToDouble(screenValue[0]))).ToString();
        }

        public void inverse()
        {
            if (Convert.ToDouble(screenValue[0]) != 0)
            {
                screenValue[0] = (1 / (Convert.ToDouble(screenValue[0]))).ToString();
            }
        }

        public void plusMinus()
        {
            if (Convert.ToDouble(screenValue[0]) != 0)
            {
                screenValue[0] = (-(Convert.ToDouble(screenValue[0]))).ToString();
            }
        }

        public void enter()
        {
            screenValue[3] = screenValue[2];
            screenValue[2] = screenValue[1];
            screenValue[1] = screenValue[0];
            eventOccurred = OPERATION_TYPE.enterOccurred;
        }
    }
}

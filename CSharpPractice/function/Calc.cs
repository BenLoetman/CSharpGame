using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.function
{

    // Struct to be used in List that specifies what the parameters are. 
    class CalcStruc
    {
        public required double FNum { get; set; }
        public required double SNum { get; set; }
        public required string OSymbol { get; set; }
    }

    internal class Calc
    { 
        private double number1, number2;
        private string symbol, returnString = "";

        // Default constructor where class members are set.
        public Calc(double number1, double number2, string symbol)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.symbol = symbol;
        }

        // Only method that can be accessed from outside class.
        public string CheckEquation()
        {
            // Check what the symbol is then call method.
            switch(this.symbol)
            {
                case "+":
                    Add();
                    break;
                case "-": 
                    Subtract(); 
                    break;
                case "*":
                    Multiply();
                    break;
                case "/":
                    Divide();
                    break;
                default:
                    break;
            }
 
            return this.returnString;
        }

        // Add method uses class member then set returnString method.
        private void Add()
        {
            double sum = this.number1 + this.number2;
            this.returnString = "The sum of " + this.number1.ToString() + " and " + this.number2.ToString() + " is " + sum.ToString();
        }
        
        // Subtract method uses class member then set returnString method.
        private void Subtract()
        {
            double sum = this.number1 - this.number2;
            this.returnString = this.number1.ToString() + " minus " + this.number2.ToString() + " is " + sum.ToString();
        }

        // Multiply method uses class member then set returnString method.
        private void Multiply()
        {
            double sum = this.number1 * this.number2;
            this.returnString = this.number1.ToString() + " times " + this.number2.ToString() + " is " + sum.ToString();
        }

        // Divide method uses class member then set returnString method.
        private void Divide()
        {
            double sum = this.number1 / this.number2;
            this.returnString = this.number1.ToString() + " divided by " + this.number2.ToString() + " is " + sum.ToString();
        }
    }
}

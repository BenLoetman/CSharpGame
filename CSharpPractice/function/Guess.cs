using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.function
{

    public class GuessStruct
    {
        public required int num { get; set; }
    }

    internal class Guess
    {
        private int num;
        private Random rnd = new Random();

        public Guess(int num) 
        {
            this.num = num;
        }

        public string GuessNum()
        {
            int x, y;
            CompareNumber(out x, out y);
            return "\nThe generated number is: " + x.ToString() + "\nYour number is: " + this.num.ToString() + "\nThe difference is: " + y.ToString();
        }

        private void CompareNumber(out int generatedNumber, out int difference) 
        {
            generatedNumber = rnd.Next(0, 101);
            if (generatedNumber - this.num  >= 0)
            {
                difference = generatedNumber - this.num;
            }
            else
            {
                difference = this.num - generatedNumber;
            }
        } 

    }
}

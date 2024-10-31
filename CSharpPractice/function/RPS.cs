using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.function
{
    public class RPSStruct
    {
        public required List<string> userChoices;
    }

    internal class RPS
    {
        private string[] possibleChoices = { "R", "P", "S" };
        private List<string> userChoices;

        public RPS(List<string> userChoices) 
        {
            this.userChoices = userChoices;
        }

        public string PlayRPC()
        {
            Random random = new Random();
            int index = random.Next(possibleChoices.Length);
            string randomSelection = possibleChoices[index];

            List<string> winner;

            foreach (string choice in userChoices)
            {
                getWinner(ref winner, choice);
            }

            return "";
        }
        private void getWinner(ref List<string> winner, string userChoice)
        {

        }

    }
}

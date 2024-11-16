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

    // Parent class to set possible choices and number associated.
    internal class SetVariables
    {
        internal string[] possibleChoices = { "R", "P", "S" };

        protected int ConvertToNumber(string choice)
        {
            switch (choice)
            {
                case "R": return 1;
                case "P": return 2;
                case "S": return 3;
                default: return 0;
            }
        }
    }

    // Inherit class
    internal class RPS: SetVariables
    {
        // Create empty list to hold what the user choose.
        private List<string> userChoices;


        // Struct to be used in List that specifies what the parameters are. 
        public RPS(List<string> userChoices) 
        {
            this.userChoices = userChoices;
        }

        // Method to simulate RPS games
        public List<string> PlayRPS(out string winPlayer)
        {
            // Create List of the winner of each round. 
            List<string> winner = new List<string>();

            int winnerNum = 0;

            // For every choice Check to see who won.
            foreach (string choice in userChoices)
            {
                GetWinner(ref winner, ref winnerNum, choice);
            }

            // If number is 0 it's a tie; 1 the user won; 2 the computer won.
            if (winnerNum == 0)
            {
                winPlayer = "Tie";
            }
            else if (winnerNum >= 1)
            {
                winPlayer = "Player";
            }
            else
            {
                winPlayer = "Computer";
            }

            return winner;
        }

        // Get the winner for each round.
        private void GetWinner(ref List<string> winner, ref int winnerNum, string userChoice)
        {

            // Get random choice and convert to number.
            Random random = new Random();
            int index = random.Next(possibleChoices.Length);
            string randomSelection = possibleChoices[index];

            int randomSelectionNum = ConvertToNumber(randomSelection);
            int userChoiceNum = ConvertToNumber(userChoice);


            // Math to calulate who won rock paper sissors. This elimates the need to have multiple if statements to compare rock, paper, and sissors.   
            int result = (3 + userChoiceNum - randomSelectionNum) % 3;


            // Based on result adds to winner list what the choices were for each round. 
            switch (result)
            {
                case 0:
                    winner.Add("User: " + userChoice + " Computer: " + randomSelection);
                    break;
                case 1:
                    winner.Add("User: " + userChoice + " Computer: " + randomSelection);
                    winnerNum += 1;
                    break;
                case 2:
                    winner.Add("User: " + userChoice + " Computer: " + randomSelection);
                    winnerNum -= 1;
                    break;
                default:
                    break;
            }
        }
    }
}

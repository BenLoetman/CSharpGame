
using CSharpPractice.function;
using System.Linq;

class Practice
{
    static void Main(string[] args)
    {
        // Call other methods that populates data and then calls the class.

        DisplayCalc();

        DisplayGuess();

        DisplayRPS();
    }

    private static void DisplayCalc()
    {

        // List of data (the two numbers then the operation) to be passed to the CalcStruct class. 
        List<CalcStruc> data = new List<CalcStruc>();

        data.Add(new CalcStruc { FNum = 5, SNum = 6, OSymbol = "+" });
        data.Add(new CalcStruc { FNum = 6, SNum = 7, OSymbol = "*" });
        data.Add(new CalcStruc { FNum = 15, SNum = 13, OSymbol = "-" });
        data.Add(new CalcStruc { FNum = 15, SNum = 5, OSymbol = "/" });


        // Pass parameters and calls method CheckEquation to return result.
        var results = data.Select(d => new Calc(d.FNum, d.SNum, d.OSymbol).CheckEquation());

        // Output the result.
        Parallel.ForEach(results, result =>
        {
            Console.WriteLine(result);
        });
    }

    private static void DisplayGuess()
    {
        // List of gusess. 
        List<GuessStruct> data = new List<GuessStruct>()
        {
            new GuessStruct{num = 5},
            new GuessStruct{num = 96},
        };

        // Call method GuessNum to compute if the guessnum is greater or less then the random number. 
        var results = data.Select(d => new Guess(d.num).GuessNum());
        

        // Output result
        Parallel.ForEach(results, result =>
        {
            Console.WriteLine(result);
        });
    }

    private static void DisplayRPS()
    {
        // winPlayer is an out parameter where t6he value is changed in the class then returned and outputted on screen. 
        string winPlayer = "";


        // 1 game of rock paper sissors.
        List<RPSStruct> data = new List<RPSStruct>()
        {
            new RPSStruct{ userChoices = ["R", "P", "S", "R"] }
        };


        // Call method PlayRPS and pass out parameter.
        var results = data.Select(d => new RPS(d.userChoices).PlayRPS(out winPlayer));

        // Output result
        Console.WriteLine("\n");
        Parallel.ForEach(results, result =>
        {
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        });
        Console.WriteLine(winPlayer);

    }
}
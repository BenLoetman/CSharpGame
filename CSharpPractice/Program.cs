
using CSharpPractice.function;
using System.Linq;

class Practice
{
    static void Main(string[] args)
    {
        DisplayCalc();

        DisplayGuess();
    }

    private static void DisplayCalc()
    {
        List<CalcStruc> data = new List<CalcStruc>()
        {
            new CalcStruc{FNum = 5, SNum = 6, OSymbol = "+"},
            new CalcStruc{FNum = 6, SNum = 7, OSymbol = "*"},
            new CalcStruc{FNum = 15, SNum = 13, OSymbol = "-"},
            new CalcStruc{FNum = 15, SNum = 5, OSymbol = "/"},
        };

        var results = data.Select(d => new Calc(d.FNum, d.SNum, d.OSymbol).CheckEquation());

        Parallel.ForEach(results, result =>
        {
            Console.WriteLine(result);
        });
    }

    private static void DisplayGuess()
    {
        List<GuessStruct> data = new List<GuessStruct>()
        {
            new GuessStruct{num = 5},
            new GuessStruct{num = 96},
        };

        var results = data.Select(d => new Guess(d.num).GuessNum());
        Parallel.ForEach(results, result =>
        {
            Console.WriteLine(result);
        });

    }
}
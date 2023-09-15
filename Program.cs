// See https://aka.ms/new-console-template for more information
using Michelangelo;

var result = Fibonnaci.Run(int.Parse(args[0]));
Console.WriteLine($"Voici le resultat {result}");
/*
int Fib(int i) => i switch
{
    int when i <= 2 => 1, _ => Fib(i - 2) + Fib(i - 1)
}
;

System.Console.WriteLine("The result is " + Fib(int.Parse(args[0])));
*/
namespace Michelangelo
{
    public class Fibonnaci
    {
        public static int Run(int i)
        {
            if (i <= 2) return 1;
            return Run(i - 1) + Run(i - 2);
        }
    }
}




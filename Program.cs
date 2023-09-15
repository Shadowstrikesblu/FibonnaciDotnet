// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Leonardo;

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
foreach (var arg in args)
{
    var result = Fibonacci.Run(int.Parse(arg));
    Console.WriteLine("$Hello {result}");
    Console.WriteLine($"Elapsed time : {stopwatch.ElapsedMilliseconds} ms" );

}
stopwatch.Stop();
Console.WriteLine("Total elapsed : {0} ms ", stopwatch.ElapsedMilliseconds);

namespace Leonardo
{
    public class Fibonacci
    {
        public static int Run(int i) { 
            if(i<=2) return 1;
            return Run(i-2) + Run(i-1);
        }

    }
}

// See https://aka.ms/new-console-template for more information
using System;
var fibonacci = new Fibonacci();
var result = fibonacci.Run(Convert.ToInt32(args[0]));
System.Console.WriteLine("The result is  " + result ); 

// var result = fibonacci.Run(3);

class Fibonacci { 
    public int Run(int i) { 
        if(i<=2) return 1;
        return Run(i-2) + Run(i-1);
    }
}


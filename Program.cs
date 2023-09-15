// See https://aka.ms/new-console-template for more information
using System;
int Fib(int i) =>     i switch    {        int when i<=2 => 1,        _ => Fib(i-2) + Fib(i-1)    };System.Console.WriteLine("The result is " +  Fib(int.Parse(args[0])));



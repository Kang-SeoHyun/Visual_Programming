// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!:) ");
Console.WriteLine("What's your name?");

var name = Console.ReadLine();
var currentDate = DateTime.Now;

Console.WriteLine();
Console.WriteLine($"Hello, {name}, on {currentDate:d} at {currentDate:t}!");
Console.Write($"Press any key to exit..");
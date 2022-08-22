// See https://aka.ms/new-console-template for more information
Console.WriteLine("Scrivi un numero intero positivo");
var addendoA = int.Parse(Console.ReadLine());
Console.WriteLine("Scrivi un altro numero intero positivo.");
var addendoB = int.Parse(Console.ReadLine());

var calc = new Calcolatrice();
Console.WriteLine($"La somma è: {calc.SommaInteri(addendoA, addendoB)}.");

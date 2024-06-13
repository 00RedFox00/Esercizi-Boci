// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("---------- System Opeartive ----------");
Console.Write("Ciao! Scrivi qualcosa : "); 
Console.ForegroundColor = ConsoleColor.Red;
string datauser = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Hai scritto questo -> " + datauser );
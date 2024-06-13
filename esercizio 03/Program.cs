// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("---------- System Opeartive ----------");
Console.Write("Inserire un valore 1 : ");
Console.ForegroundColor = ConsoleColor.Red;
string val1 = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Inserire un valore 2 : ");
Console.ForegroundColor = ConsoleColor.Red;
string val2 = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("La somma dei 2 valori è : " + (Int32.Parse(val1) + Int32.Parse(val2)));
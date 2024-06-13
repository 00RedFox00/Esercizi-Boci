// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("---------- System Opeartive ----------");
Console.Write("Inserire un valore : ");
Console.ForegroundColor = ConsoleColor.Red;
string datauser = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
int number;
bool success = int.TryParse(datauser, out number);
if (success)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Il valore '{datauser}' è un numero intero.");
} 
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"ERRORE! '{datauser}' non è un numero intero!");
}
Console.ForegroundColor = ConsoleColor.White;
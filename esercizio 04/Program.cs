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
Console.Write("Inserire l'operatore : ");
Console.ForegroundColor = ConsoleColor.Red;
string op = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
switch (op)
{
    case "+":
        Console.ForegroundColor = ConsoleColor.Blue;
        try
        {
            Console.Write("La somma dei 2 valori è : " + (Int32.Parse(val1) + Int32.Parse(val2)));
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Errore, non è possibile continuare l'espressione a causa di un errore durante la scrittura delle variabili e/o del calcolo che risulta impossibile");
        }
        break;
    case "-":
        Console.ForegroundColor = ConsoleColor.Blue;
        try
        {
            Console.Write("La sottrazzione dei 2 valori è : " + (Int32.Parse(val1) - Int32.Parse(val2)));
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Errore, non è possibile continuare l'espressione a causa di un errore durante la scrittura delle variabili e/o del calcolo che risulta impossibile");
        }
        break;
    case "*":
        Console.ForegroundColor = ConsoleColor.Blue;
        try
        {
            Console.Write("La moltiplicazione dei 2 valori è : " + (Int32.Parse(val1) * Int32.Parse(val2)));
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Errore, non è possibile continuare l'espressione a causa di un errore durante la scrittura delle variabili e/o del calcolo che risulta impossibile");
        }
        break;
    case "/":
        Console.ForegroundColor = ConsoleColor.Blue;
        try
        {
            Console.Write("La divisione dei 2 valori è : " + (Int32.Parse(val1) / Int32.Parse(val2)));
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Errore, non è possibile continuare l'espressione a causa di un errore durante la scrittura delle variabili e/o del calcolo che risulta impossibile");
        }
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("È stato inserito un valore non riconosciuto, per favore, riprova, inserendo uno tra i seguenti valori => + - * /");
        break;
}
Console.ForegroundColor = ConsoleColor.White;
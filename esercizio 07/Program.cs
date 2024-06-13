// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("---------- Calcolatrice ----------");

string command = "";
decimal a = 0;
decimal b = 0;
Boolean errorzero = false;

List<string> termini = new();

while (command != "exit")
{
    Console.WriteLine("inserisci il comando (ineo = inserisci numero e operatore, pa = pulisci array, exit = esci):");
    command = Console.ReadLine()!;


    switch (command)
    {
        case ("ineo"):
            {
                Console.Write("inserisci numero: ");
                termini.Add(Console.ReadLine()!);
                Console.Write("inserisci operatore (+, -, *, /, =): ");
                termini.Add(Console.ReadLine()!);
                if (termini.Last() == "=")
                {
                    Console.Write("Faccio l'operazione tra questi: ");
                    termini.ForEach(x => { Console.Write("{0}", x); });
                    for (int i = 1; i < termini.Count; i = i + 2)
                    {
                        switch (termini[i])
                        {
                            case ("+"):
                                {
                                    if (a == 0)
                                    {
                                        b = decimal.Parse(termini[i - 1]) + decimal.Parse(termini[i + 1]);
                                        a++;
                                        Console.WriteLine("SOMMA 1 => " + b);
                                    }
                                    else
                                    {
                                        b = b + decimal.Parse(termini[i + 1]);
                                        Console.WriteLine("SOMMA => " + b);
                                    }
                                    //termini.RemoveAt(i + 1);
                                    //termini.Insert(i + 1, a.ToString());
                                    break;
                                }
                            case ("-"):
                                {
                                    if (a == 0)
                                    {
                                        b = decimal.Parse(termini[i - 1]) - decimal.Parse(termini[i + 1]);
                                        a++;
                                        Console.WriteLine("SOTTR 1 => " + b);
                                    }
                                    else
                                    {
                                        b = b - decimal.Parse(termini[i + 1]);
                                        Console.WriteLine("SOTTR => " + b);
                                    }
                                    //termini.RemoveAt(i + 1);
                                    //termini.Insert(i + 1, a.ToString());
                                    break;
                                }
                            case ("*"):
                                {
                                    if (a == 0)
                                    {
                                        b = decimal.Parse(termini[i - 1]) * decimal.Parse(termini[i + 1]);
                                        a++;
                                        Console.WriteLine("MOLT 1 => " + b);
                                    }
                                    else
                                    {
                                        b = b * decimal.Parse(termini[i + 1]);
                                        Console.WriteLine("MOLT => " + b);
                                    }
                                    //termini.RemoveAt(i + 1);
                                    //termini.Insert(i + 1, a.ToString());
                                    break;
                                }
                            case ("/"):
                                {
                                    if (decimal.Parse(termini[i + 1]) == 0)
                                    {
                                        Console.WriteLine("Impossibile dividere per zero!");
                                        i = termini.Count;
                                        errorzero = true;
                                        break;
                                    }
                                    else if (a == 0)
                                    {

                                        b = decimal.Parse(termini[i - 1]) / decimal.Parse(termini[i + 1]);
                                        a++;
                                        Console.WriteLine("DIVIS 1 => " + b);
                                    }
                                    else
                                    {
                                        b = b / decimal.Parse(termini[i + 1]);
                                        Console.WriteLine("DIVIS => " + b);
                                    }
                                    //termini.RemoveAt(i + 1);
                                    //termini.Insert(i + 1, a.ToString());
                                    break;
                                }
                        }
                    }
                    if (errorzero == false)
                    {
                        Console.WriteLine("Il risultato è => " + b);
                    }
                    termini = new();
                    b = 0;
                    a = 0;
                }

                break;
            }
        case ("pa"):
            {
                termini = new();

                break;
            }
        default:
            {
                Console.WriteLine("comando non trovato");
                break;
            }
    }
}
// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel;

Console.WriteLine("---------- Calcolatrice ----------"); string command = "";
decimal a = 0;
decimal b = 0;
int i = 0;
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
                    Console.WriteLine("Faccio l'operazione tra questi numeri: ");
                    termini.ForEach(x => {Console.Write("{0} ", x);});
                    Console.WriteLine();

                    for (i = 0; i < termini.Count; i++)
                    {
                        if (termini[i] == "*")
                        {
                            b = decimal.Parse(termini[i - 1]) * decimal.Parse(termini[i + 1]);
                            termini[i - 1] = b.ToString();
                            termini.RemoveAt(i);
                            termini.RemoveAt(i);
                            i--;
                        }
                        else if (termini[i] == "/")
                        {
                            if (decimal.Parse(termini[i + 1]) != 0)
                            {
                                b = decimal.Parse(termini[i - 1]) / decimal.Parse(termini[i + 1]);
                                termini[i - 1] = b.ToString();
                                termini.RemoveAt(i);
                                termini.RemoveAt(i);
                                i--;
                            }
                            else
                            {
                                errorzero = true;
                                Console.WriteLine("Errore! Impossibile dividere per zero!");
                                break;
                            }
                        }
                    }

                    if (!errorzero)
                    {
                        for (i = 0; i < termini.Count; i++)
                        {
                            if (termini[i] == "+")
                            {
                                b = decimal.Parse(termini[i - 1]) + decimal.Parse(termini[i + 1]);
                                termini[i - 1] = b.ToString();
                                termini.RemoveAt(i);
                                termini.RemoveAt(i);
                                i--;
                            }
                            else if (termini[i] == "-")
                            {
                                b = decimal.Parse(termini[i - 1]) - decimal.Parse(termini[i + 1]);
                                termini[i - 1] = b.ToString();
                                termini.RemoveAt(i);
                                termini.RemoveAt(i);
                                i--;
                            }
                        }

                        Console.WriteLine("Il risultato è => " + b);
                    }

                    termini = new();
                    b = 0;
                    a = 0;
                    errorzero = false;
                }

                break;
            }
        case ("pa"):
            {
                termini = new();
                Console.WriteLine("Array pulito.");
                break;
            }
        default:
            {
                Console.WriteLine("comando non trovato");
                break;
            }
    }
}
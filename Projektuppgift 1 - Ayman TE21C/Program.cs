using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till 21:an!");

        Random slump = new Random();
        string senast = "Ingen har vunnit än";
        string val = "0";
        while (val != "4")
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Spela 21:an");
            Console.WriteLine("2. Vissa senaste vinnare");
            Console.WriteLine("3. Spelets regler");
            Console.WriteLine("4. Avsluta spelet");
            val = Console.ReadLine();

            Console.WriteLine();

            switch (val)
            {
                case "1":
                    int dator = 0;
                    int spelare = 0;
                    Console.WriteLine("Nu kommer två kort att dras per spelare");
                    for (int i = 0; i < 2; i++)
                    {
                        dator += slump.Next(1,11);
                        spelare += slump.Next(1,11);
                    }

                    string kort = "";
                    while (kort != "n" && spelare <= 21)
                    {
                        Console.WriteLine($"Din total poäng är {spelare}");
                        Console.WriteLine($"Datorns total poäng är {dator}");
                        Console.WriteLine("Vill du ha en till kort? j/n");
                        kort = Console.ReadLine();
                        if (kort == "j")
                        {
                            int Sny = slump.Next(1,11);
                            spelare += Sny;
                            Console.WriteLine($"Din nya kort är {Sny} poäng");
                        }
                        else if (kort == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du valde inte ett giltigt alternativ!");
                        }
                    }
                    if (spelare > 21)
                    {
                        Console.WriteLine($"Din total poäng är {spelare}");
                        Console.WriteLine("Du har över 21 total poäng du har förlurat");
                        Console.ReadKey();
                    }
                    else
                    {
                        while (dator < spelare && dator <= 21)
                        {
                            int Dny = slump.Next(1, 11);
                            dator += Dny;
                            Console.WriteLine($"Datorn drog ett kort och är {Dny}");
                            Console.WriteLine($"Datorns total poäng är {dator}");
                        }

                        if (dator > 21)
                        {
                            Console.Write("\nDu har vunnit \nSkriv in ditt namn: ");
                            senast = Console.ReadLine();
                        }
                        else if ( dator <= 21 && dator >= spelare)
                        {
                            Console.WriteLine($"Din total poäng är {spelare}\n");
                            Console.WriteLine("Du har förlurat \nDatorn har lika/mer poäng än dig");
                            Console.ReadKey();
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine($"Senaste vinnare: {senast}");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Ditt mål är att tvinga datorn att få mer 21 poäng." +
                        "\nDu får poäng genom att dra ett kort som har värdet mellan 1 och 10." +
                        "\nOm du får mer än 21 poäng har du förlorat. \nBåde du och datorn får två kort i början." +
                        "\nDärefter får du dra fler kort tills du är nöjd eller får över 21 poäng." +
                        "\nNär du är färdig drar datorn kort tills den har lika/mer poäng än dig eller över 21 poäng.");
                    Console.ReadKey();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Du valde inte ett giltigt alternativ");
                    break;
            }
            Console.WriteLine();
        }
    }
}

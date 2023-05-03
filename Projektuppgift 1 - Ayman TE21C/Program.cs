using System;

class program
{
    static void Main(string[] args)
    {
        int maxpoäng = 21;
        Console.WriteLine($"Välkommen till {maxpoäng}:an!");

        Random slump = new Random();
        int minkort = 1;
        int maxkort = 11;
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
                        dator += slump.Next(minkort, maxkort);
                        spelare += slump.Next(minkort, maxkort);
                    }

                    string kort = "";
                    while (kort != "n" && spelare <= maxpoäng)
                    {
                        Console.WriteLine($"Din total poäng är {spelare}");
                        Console.WriteLine($"Datorns total poäng är {dator}");
                        Console.WriteLine("Vill du ha en till kort? j/n");
                        kort = Console.ReadLine();
                        if (kort == "j")
                        {
                            int Sny = slump.Next(minkort, maxkort);
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
                    if (spelare > maxpoäng)
                    {
                        Console.WriteLine($"Din total poäng är {spelare}");
                        Console.WriteLine("Du har över 21 total poäng du har förlurat");
                        Console.ReadKey();
                    }
                    else
                    {
                        while (dator < spelare && dator <= maxpoäng)
                        {
                            int Dny = slump.Next(minkort, maxkort);
                            dator += Dny;
                            Console.WriteLine($"Datorn drog ett kort och är {Dny}");
                            Console.WriteLine($"Datorns total poäng är {dator}");
                        }

                        if (dator > maxpoäng)
                        {
                            Console.Write("\nDu har vunnit \nSkriv in ditt namn: ");
                            senast = Console.ReadLine();
                        }
                        else if ( dator <= maxpoäng && dator >= spelare)
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
                    Console.WriteLine($"Ditt mål är att tvinga datorn att få mer {maxpoäng} poäng." +
                        $"\nDu får poäng genom att dra ett kort som har värdet mellan {minkort} och {maxkort-1}." +
                        $"\nOm du får mer än {maxpoäng} poäng har du förlorat. \nBåde du och datorn får två kort i början." +
                        $"\nDärefter får du dra fler kort tills du är nöjd eller får över {maxpoäng} poäng." +
                        $"\nNär du är färdig drar datorn kort tills den har lika/mer poäng än dig eller över {maxpoäng} poäng.");
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

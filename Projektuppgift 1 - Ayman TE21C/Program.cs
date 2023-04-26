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
                        "\nNär du är färdig drar datorn kort tills den har mer poäng än dig eller över 21 poäng.");
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

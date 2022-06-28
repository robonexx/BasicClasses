using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Diagnos_1_Grund
{

    class Bil
    {
        public string RegistreringsNummer;  // Här sparas varje bils registreringsnummer
        public string Tillverkare;          // Här sparas varje bils tillverkare
        public int Årtal;                   // Här sparas varje bils tillverkningsår
        public bool Besiktad;               // Här sparas information huruvida bilen är besiktad

        public Bil(string _registrering, string _tillverkare, int _årtal, bool _besiktad) // Här startar bilens konstruktor
        {
            RegistreringsNummer = _registrering;          // Mottaget registreringsnummer tilldelas till objektets registreringsnummer
            Tillverkare = _tillverkare;                   // Mottaget tillverkare tilldelas till objektets tillverkare
            Årtal = _årtal;                               // Mottaget årtal tilldelas till objektets årtal
            Besiktad = _besiktad;                         // Mottagen besiktningsinformation tilldelas till objektets besiktning
        }

        public override string ToString() // Här börjar Bilklassens ToString. Dess standardiserade utskrift
        {
            if (Besiktad)                                                // En utskrift om bilen är besiktad

                return "\n\t\t" + Tillverkare + " (" + Årtal + ")"
                + "\n\t\t" + RegistreringsNummer
                + "\n\t\tBesiktad";

            else
                // En utskrift om bilen är obesiktad
                return "\n\t\t" + Tillverkare + " (" + Årtal + ")"
                + "\n\t\t" + RegistreringsNummer
                + "\n\t\tObesiktad";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Övning 1 bilar
            /* Bil bil1 = new Bil("ABC123", "Volvo", 1991, false);
             Bil bil2 = new Bil("XYZ789", "Toyota", 1987, true);

             Console.WriteLine(bil1);

             bil1.Årtal = 1997;

             Console.WriteLine(bil1 + "\n" + bil2);

             // för att få ut äldsta bilen av det 2
             // om man vill ha nyare bilen så kan man välja utkommenterade if statement
             if (bil1.Årtal < bil2.Årtal) // Äldsta bilen
                // if (bil1.Årtal > bil2.Årtal) // Nyaste bilen
                 {
                 Console.WriteLine(bil1);
               }
                 else
               {
                 Console.WriteLine(bil2);
               }

             Console.ReadKey();
             */
           
            List<Bil> bilRegister = new List<Bil>();

            // Meny för program
            bool isActive = true;
            while (isActive)
            {
                Meny();

                string användarVal = Console.ReadLine();

                if (användarVal == "1")
                {
                    Console.Clear();
                    string registreringsNummer = "";                        // Initierar registreringsplåt, tillverkare och besiktad-variablerna
                    string tillverkare = "";
                    int årtal = 0;
                    bool besiktad = false;

                    Console.WriteLine("\n\t Registrera ny bil"
                      + "\n\t Ange registrering 3 bokstäver A-Ö och 3 siffror 0-9 i följd");

                    Console.Write("\t  ");
                    registreringsNummer = Console.ReadLine().ToUpper();

                    if (registreringsNummer.Length != 6 || registreringsNummer.Length == 0)
                    {
                        Console.WriteLine("\n\t Registrerings nummret måste vara 6 karaktärer"
                        + "\n\t Ange registrering 3 bokstäver A-Ö och 3 siffror 0-9 i följd");
                    }
                    else
                    {
                        Console.WriteLine("din bil med registreringsnummer " + registreringsNummer + " är nu registrerad");
                    }

                    Console.WriteLine("\n\t Ange tillverkare");
                    Console.Write("\t * ");
                    tillverkare = Console.ReadLine().ToUpper();

                    Console.WriteLine("Bilen är tillverkad av " + tillverkare);

                    Console.WriteLine("\n\t Ange tillverknings år");
                    årtal = int.Parse(Console.ReadLine());

                    Console.WriteLine("\t Tillverknings år på bilen är " + årtal);


                    string input = "";
                    string inputBesiktning = "";
                    Console.WriteLine("\t Är bilen besiktad? J för Ja / N för Nej");
                    input = Console.ReadLine().ToUpper();

                    if (input == "J")
                    {
                        besiktad = true;
                        inputBesiktning = "Besiktad";
                    }
                    else if (input == "N")
                    {
                        besiktad = false;
                        inputBesiktning = "Obesiktad";
                    }
                    else
                    {
                        Console.WriteLine("Du måste välja J för Ja eller N för Nej");
                    }
                    Console.WriteLine("Bilen är  " + inputBesiktning);

                    // Skapar en ny bil med egenskaper och lägger till i bil registret
                    Bil nyBil = new Bil(registreringsNummer, tillverkare, årtal, besiktad);
                     
                    bilRegister.Add(nyBil);

                    Console.WriteLine("\n\n\t\t Tryck på valfri knapp för att fortsätta");
                    Console.ReadKey();

                }

                // se bilar i registret, lista  med bilar
                else if (användarVal == "2")
                {
                  if(bilRegister.Count > 0)
                    {
                        foreach(Bil bil in bilRegister)
                        {
                            Console.WriteLine("\n\t " + bil + "\n\n " 
                                + "\n\t\t Tryck på valfri knapp för att fortsätta" );
                            Console.ReadKey();
                        }
                    }
                    // om det ej finns bilar, skriver ut ett meddelande
                    else
                    {                                                     
                        Console.WriteLine("\n\t Inga registrerade bilar, Genom att välja alternativ 1 kan du lägga till en ny bil i registret"); 
                    }
                    
                }
                else if (användarVal == "3")
                {
                    Console.WriteLine("\n\t ");
                }
                else if (användarVal == "4")
                {
                    Console.WriteLine("\n\t Avsluta? tryck på en knapp för att fortsätta");
                    isActive = false;
                    //  Console.ReadKey();
                    //Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\n\t Du måste välja an siffra 1-4");
                }

            }

        }

        // Creating the program menu and options
        private static void Meny()
        {
          
            Console.WriteLine("\n\n\t"
              + "\n\t - Roffes bilar (register) -"
              + "\n\t ========================"
              + "\n\t Välj ett alternativ 1, 2, 3 eller 4"
              + "\n\n\t 1) Alternativ 1 - Registrera bil"
              + "\n\t 2) Alternativ 2 - Registrerade bilar"
              + "\n\t 3) Alternativ 3 - Hämta bilar från register"
              + "\n\t 4) Alternativ 4 - Stäng program");

        }

        // from MDN and stack 
        // get a letter a-ö, swedish alphabet
        public static char GetLetter()
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars.ToUpper()[num];
        }

        // get a random number from 0-9
        public static char GetNumber()
        {
            string chars = "0123456789";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }
    }
}

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
            Bil bil1 = new Bil("ABC123", "Volvo", 1991, false);

            Bil bil2 = new Bil("XYZ789", "Toyota", 1987, true);

            Console.WriteLine(bil1);

            bil1.Årtal = 1997;

            Console.WriteLine(bil1 + "\n" + bil2);

            Console.ReadKey();
        }
    }
}

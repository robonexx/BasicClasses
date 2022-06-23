using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "OldsMobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1991;
            myCar.Color = "Black";

            Console.WriteLine( "{0},{1},{2},{3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            // decimal value = DetermineMarketValue(myCar);
            //
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
            Console.ReadKey();
        }

        
    }

    class Car
    {
        public string Make { get; set;  }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)

                carValue = 8000.0M;

            else

                carValue = 3000.0M;

            return carValue;
        }
    }
}

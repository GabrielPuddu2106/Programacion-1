using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Members
    {
        public static void Main(String [] args)
        {
            Coffee coffee1 = new Coffee();

            coffee1.Name = "Fourth Espreso";
            coffee1.IsFairTrade = true;

            int servingTemp = coffee1.GetServingTemperature();

            //
            coffee1.Bean = "Arabaica";

            coffee1.Roast = "Dark";

            coffee1.CountryOfOrigin = "Columbia";

            Console.WriteLine("Nombre del cafe: ");
            Console.WriteLine(coffee1.Name);
            Console.WriteLine("Tipo de cafe: ");
            Console.WriteLine(coffee1.Bean);
            Console.WriteLine("Tipo de tostado: ");
            Console.WriteLine(coffee1.Roast);
            Console.WriteLine("Lugar de origen: ");
            Console.WriteLine(coffee1.CountryOfOrigin);
        }
    }
}

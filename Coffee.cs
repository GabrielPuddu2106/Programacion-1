using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Coffee : Beverage
    {

        public Coffee()
        {
            //Este constructor llama implicitamente al constructor de bebidas predeterminado

            //La declaracion es amalicitamente equivalente a la classe Coffe()
        }

        public Coffee(String name, bool isFairTrade, int servingTeamp, string bean, string roast) : base(name, isFairTrade, servingTeamp)
        {  

            Bean = bean;
            Roast = roast;  

        }
        public string Bean { get; set; }
        public string Roast { get; set; }
        public string CountryOfOrigin { get; set; }

        bool iced = false;
        protected int servingTempIced = 40;
        public override int GetServingTemperature()
        {
            if (iced)
            {
                return servingTempIced;

            }
            else
            {
                return base.GetServingTemperature();
            }
        }

    }
}

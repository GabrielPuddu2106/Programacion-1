using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Beverage
    {
        protected int servingTemperature;

        public string Name { get; set; }

        public bool IsFairTrade { get; set; }

        public virtual int GetServingTemperature()
        {
            return servingTemperature;
        }

        public Beverage()
        {
            //Implementation details not shown
        }

        public Beverage(string name, bool isFairTrade, int servingTemp)
        {
            //Implementation details are not shown.
        }

        //Other class members are not shown.
    }
}

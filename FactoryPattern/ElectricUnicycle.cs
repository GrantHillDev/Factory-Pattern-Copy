using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ElectricUnicycle : IVehicle
    {
        //public int numberOfWheels { get; set; } = 1;

        public ElectricUnicycle()
        {

        }

        public void Drive()
        {
            Console.WriteLine("Ha, check out that motorized unicycle making its way down the sidewalk....");
            Console.WriteLine("");
        }
    }
}

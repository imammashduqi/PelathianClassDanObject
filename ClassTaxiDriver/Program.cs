using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxiDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi
            TaxiClass taxi = new TaxiClass();

            // pengertian nilai properties
            taxi.DriverName = "Pak imam";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;

            // pemanggil method
            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}

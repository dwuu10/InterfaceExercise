using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle , ICompany
    {
        public Truck()
        {
            seats = 2;
            engineSound = "grrrrrrrrrrrrrrrrr";
            fuelType = "Diesel";
        }
        public int wheels { get; set; }
        public int seats { get; set; }
        public string engineSound { get; set; }
        public string fuelType { get; set; }

        public string Logo { get; set; }
        public string motto { get; set; }

        public int bedSize { get; set; }
        public void Hauling()
        {
            Console.WriteLine("This Truck is powerful and can carry large loads");
        }
    }
}

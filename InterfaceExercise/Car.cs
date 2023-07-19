using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany 
    {
        public Car()
        {
            wheels = 4;
            hasTrunk = true;
            fuelType = "Gasoline";
            engineSound = "Vroom Vroom";
        }
        public int wheels { get; set; }
        public int seats { get; set; }
        public string engineSound { get; set; }
        public string fuelType { get; set; }

        public string Logo { get; set; }
        public string motto { get; set; }

        public bool hasTrunk { get; set; }
        public void Racing()
        {
            Console.WriteLine("This car is fast and can race");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle , ICompany
    {
        public SUV()
        {
            wheels = 4;
            fuelType = "Gasoline";
            engineSound = "Vroom Vroom";
        }
        public int wheels { get; set; }
        public int seats { get; set; }
        public string engineSound { get; set; }
        public string fuelType { get; set; }

        public string Logo { get; set; }
        public string motto { get; set; }

        public int Cargo { get; set; }
        public void Offroading()
        {
            Console.WriteLine("This SUV is reliable and can drive over rough terrain");
        }
    }
}

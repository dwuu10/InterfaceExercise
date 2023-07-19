using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int wheels { get; set; }
        public int seats { get; set; }
        public string engineSound { get; set; }
        public string fuelType { get; set; }
    }
}

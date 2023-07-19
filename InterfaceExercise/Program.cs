using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var list = new List<IVehicle>();

            var car = new Car()
            {
                seats = 4,
                Logo = "a star",
                motto = "the shooting star"
            };
            list.Add(car);

            var suv = new SUV()
            {
                seats = 6,
                Logo = "a bear",
                motto = "le brown bear",
                Cargo = 6
            };
            list.Add(suv);

            var truck = new Truck()
            {
                wheels = 4,
                Logo = "the isuzu",
                motto = "truck-kun",
                bedSize = 8
            };
            list.Add(truck);

            foreach (var item in list)
            {
                Console.WriteLine($"This vehicle is a {item.GetType().Name}, it has {item.wheels} wheels and {item.seats} seats, it uses {item.fuelType} fuel and its engines makes the sound {item.engineSound}");
                Console.WriteLine();
            }

            car.Racing();
            Console.WriteLine($"this {car.GetType().Name} has {car.Logo} logo, the company's motto is {car.motto}");
            Console.WriteLine();

            suv.Offroading();
            Console.WriteLine($"this {suv.GetType().Name} has {suv.Logo} logo, the company's motto is {suv.motto}");
            Console.WriteLine();

            truck.Hauling();
            Console.WriteLine($"this {truck.GetType().Name} has {truck.Logo} logo, the company's motto is {truck.motto}");
            Console.WriteLine();
        }
    }
}

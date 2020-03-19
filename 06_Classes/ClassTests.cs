using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void VehiclePropertyTests()
        {
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Make = "VW";
            Console.WriteLine(firstVehicle.Make);
            firstVehicle.Model = "Beatle";
            firstVehicle.Mileage = 250000.1m;
            firstVehicle.TypeOfVehicle = VehicleType.ATV;

            string carDetails = $"{firstVehicle.Make} {firstVehicle.Model}!";
            Console.WriteLine(carDetails);

            Vehicle anotherV = new Vehicle("Toyota", "Corolla", 890000.42m, VehicleType.Spaceship);



        }

        [TestMethod]
        public void PersonTests()
        {
            Person firstPerson = new Person("Bella", "Knight", new DateTime(1505, 01, 29));

            Console.WriteLine($"{firstPerson.FullName} is {firstPerson.Age} years old");

            Person blankPerson = new Person();
            Console.WriteLine($"{blankPerson.FullName} is {blankPerson.Age} years old");
        }
    }
}

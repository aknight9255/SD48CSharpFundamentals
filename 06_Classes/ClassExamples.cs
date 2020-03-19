using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    public enum VehicleType { Car, Truck, StationWagon,SUV,Motorcycle,ATV,Spaceship,Boar, HorseAndBuggy}
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle() { }
        public Vehicle(string make,string model,decimal mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }
        
    }

    public class Person
    {
        public string FirstName { get; set; }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public DateTime DOB { get; set; }

        public int Age
        {
            get
            {
                if (DOB == new DateTime())
                {
                    return 9001;
                }
                TimeSpan timeSpan = DateTime.Now - DOB;
                double totalAgeInYears = timeSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld;
            }
        }

        public bool IsAdult
        {
            get
            {
                if (Age >= 21)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Person() { }
        public Person(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
        }


    }

    public class WaterBottle
    {

    }
}

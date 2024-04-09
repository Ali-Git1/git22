using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Vehicle
    {
        public string Brand;

        public string Model;

        public long Millage;

        public double CurrentFuel;

        public Vehicle(string brand, string model, int millage, int currentFuel)
        {
            Brand = brand;
            Model = model;
            Millage = millage;
            CurrentFuel = currentFuel;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Brand: ");
            string marka = Console.ReadLine();

            Console.Write("Model: ");
            string modeli = Console.ReadLine();

            Console.Write("Millage: ");
            int millage;
            while (!int.TryParse(Console.ReadLine(), out millage) || millage < 0)
            {
                Console.WriteLine("yanlis giris.yeniden cehd edin");
                Console.Write("Millage: ");
            }

            Console.Write("Current Fuel: ");
            int currentFuel;
            while (!int.TryParse(Console.ReadLine(), out currentFuel) || currentFuel < 0)
            {
                Console.WriteLine("yanlis giris.yeniden cehd edin.");
                Console.Write("Current Fuel: ");
            }

            Console.Write("Fuel Capacity: ");
            int fuelCapacity;
            while (!int.TryParse(Console.ReadLine(), out fuelCapacity) || fuelCapacity < 0)
            {
                Console.WriteLine("yanlis giris.yeniden cehd edin.");
                Console.Write("Fuel Capacity: ");
            }

            Car araba = new Car(marka, modeli, millage, currentFuel, fuelCapacity);
            araba.AddFuel(50);







        }
    }
}

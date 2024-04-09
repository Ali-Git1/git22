using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Car:Vehicle
    {
        public double FuelCapacity;

        public Car(string brand, string model, int millage, int currentFuel, int fuelCapacity)
         : base(brand, model, millage, currentFuel)
        {
            FuelCapacity = fuelCapacity;
        }


        public void AddFuel(int litersToAdd)
        {
        yoxla:
            Console.Write("elave etmek isediyiniz miqdari qeyd edin ");
            int liters;
            if (!int.TryParse(Console.ReadLine(), out liters) || liters <= 0)
            {
                Console.WriteLine("yanlis giris.yeniden cehd edin.");
                goto yoxla;
            }

            if (CurrentFuel + liters <= FuelCapacity)
            {
                CurrentFuel += liters;
                Console.WriteLine($"{liters} Elave edildi. Yeni miqdar: {CurrentFuel} litr.");
            }
            else
            {
                Console.WriteLine($"Miqdar asildi elave edile bilmedi.");
                goto yoxla;
            }
        }
    }
}

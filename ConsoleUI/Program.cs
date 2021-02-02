using Business.Concrete;
using DataAccess.Concrete.Inmemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InmemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.CarId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.ModelYear);
            }

            Console.WriteLine("Merhaba Zalim Dünya!");
        }
    }
}

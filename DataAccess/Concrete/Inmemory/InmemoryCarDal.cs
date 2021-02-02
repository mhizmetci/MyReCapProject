using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.Inmemory
{
    public class InmemoryCarDal : ICarDal
    {
        List<Car> _cars;


        public InmemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=845, ModelYear=2019, Description="Mercedes CLA 200" },
                new Car{CarId=2, BrandId=2, ColorId=1, DailyPrice=275, ModelYear=2015, Description="Renault Fluence" },
                new Car{CarId=3, BrandId=2, ColorId=2, DailyPrice=150, ModelYear=2004, Description="Renault Clio" },
                new Car{CarId=4, BrandId=3, ColorId=2, DailyPrice=285, ModelYear=2017, Description="Fiat Egea" },
                new Car{CarId=5, BrandId=4, ColorId=1, DailyPrice=450, ModelYear=2016, Description="BMW 320d" },
            };
        }
        public void Add(Car car) 
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByCar(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}

using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
             _cars = new List<Car>
            { 
            
                 new Car {CarId = 1, BrandId = 1, ColorId = 2, DailyPrice = 200, Description = "1500 KM", ModelYear = 2020},
                 new Car {CarId = 2, BrandId = 3, ColorId = 1, DailyPrice = 400, Description = "0 KM", ModelYear = 2022},
                 new Car {CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 100, Description = "2500 KM", ModelYear = 2000},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        { 
            var carToDelete = _cars.Where(c => c.CarId == car.CarId).FirstOrDefault();

             _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;   
        }

        public List<Car> GetById(int carId)
        {
            _cars.Where(c => c.CarId == carId);
            return _cars;
        }

        public void Update(Car car)
        {
            var find = _cars.Where(c => c.CarId == car.CarId).FirstOrDefault();
            find.CarId = car.CarId;
            find.BrandId = car.BrandId;
            find.ColorId = car.ColorId;
            find.DailyPrice = car.DailyPrice;
            find.Description = car.Description;
            find.ModelYear = car.ModelYear;
        }
    }
}

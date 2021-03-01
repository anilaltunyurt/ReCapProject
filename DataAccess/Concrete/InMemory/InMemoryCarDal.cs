using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1 ,CarName="Ş" ,BrandId = 1 , ColorId = 1 , DailyPrice = 150 , ModelYear = "2017" , Description = "Clio" },
                new Car{CarId = 2 ,CarName="Egea" ,BrandId = 1 , ColorId = 2 , DailyPrice = 250 , ModelYear = "2019" , Description = "Symbol" },
                new Car{CarId = 3 ,CarName="İ20" ,BrandId = 2 , ColorId = 3 , DailyPrice = 350 , ModelYear = "2020 ", Description = "Polo" },
                new Car{CarId = 4 ,CarName="Corolla" ,BrandId = 3 , ColorId = 1 , DailyPrice = 125 , ModelYear = "2017 ", Description = "Accent" },
                new Car{CarId = 5 ,CarName="Focus" ,BrandId = 3 , ColorId = 2 , DailyPrice = 400 , ModelYear = "2021 ", Description = "İ20" }
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);        
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;    
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}

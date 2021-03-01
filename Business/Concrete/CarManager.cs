﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length<2 )
            {
                Console.WriteLine("Araba ismi en az 2 karakter olmalıdır");
            }
            else if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Günlük fiyat '0'dan büyük olmalıdır.");
            }
            else
            {
                _carDal.Add(car);
                Console.WriteLine("Araç Kaydedildi..");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}

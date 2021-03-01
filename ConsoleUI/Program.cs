﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId +" = " + car.CarName);
            }
            Console.WriteLine("----------------");


            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " = " + brand.BrandName);
            }



        }




    }
}



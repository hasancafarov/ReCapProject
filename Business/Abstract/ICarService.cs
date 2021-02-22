﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        void Add(Car car);
        List<Car> GetAll();
        List<Car> GetCarsBybrandID(int id);
        List<Car> GetCarsByColorID(int id);



    }
}
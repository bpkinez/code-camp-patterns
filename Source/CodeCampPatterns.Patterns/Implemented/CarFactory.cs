﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public abstract class CarFactory
    {
        public abstract GasolineCar CreateGasolineCar();

        public abstract ElectricCar CreateElectricCar();
    }
}
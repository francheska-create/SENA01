using InterfaceSegregationPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Entities
{
    
    public class MultiFunctionalCar :IMultifuntionalCar
    {
        private readonly ICar _car;
        private readonly IAirplane _airplane;
        public MultiFunctionalCar(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }

   

        public void Drive()
        {
            _car.Drive();
        }

        public void Fly()
        {
            _airplane.Fly();
        }






        //   public void Drive()
        //    {
        //        Console.WriteLine("Drive a Multifuntional car");
        //    }

        //   public void Fly()
        //    {
        //        Console.WriteLine("Fly multifuntional car");
        //    }
    }
}

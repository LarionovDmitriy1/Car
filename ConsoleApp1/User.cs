using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User 
    {
        private int _money;
        private Car _car;
        private Car _mark;
       

        public void BuyCar(Car car)
        {
            _car = car;

           
        }
        public void Ride()
        {
            _car.Ride();
        }
        public void UpgradeCar()
        {
            _car.Upgrade();
        }

        public void GetInfo()
        {
            _car.GetInfo();
        }
        public bool CheckCar()
        {
            if (_car != null)
            {
                return true;
            }
            return false;
        }
    }
}

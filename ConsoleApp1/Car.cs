using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Car
    {
        protected int _price;
        protected int _speed;
        protected int _enginePower;
        protected string _mark;
        protected int _year;

        public abstract void Ride();

        public abstract void GetInfo();

        public abstract void Upgrade();

    }
}



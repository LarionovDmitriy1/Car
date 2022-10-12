using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mercedes : Car
    {
        public Mercedes()
        {
            _mark = "Mercedes";
            _price = 500000;
            _speed = 250;
            _enginePower = 100;
            _year = 2022;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Марка машины - {_mark}");
            Console.WriteLine($"Цена - {_price}");
            Console.WriteLine($"Максимальная скорость - {_speed}");
            Console.WriteLine($"Мощность двигателя - {_enginePower}");
            Console.WriteLine($"Год выпуска - {_year}");
            Console.WriteLine();
        }

        public override void Ride()
        {
            Console.WriteLine($"{_mark} поехала гулять");
        }

        public override void Upgrade()
        {
            _enginePower = _enginePower + 20;
            _speed = _speed + 10;
            _price = _price + 50000;
            Console.WriteLine($"Мощность двигателя у {_mark} увеличилось на 20, мощность двигателя - {_enginePower}");
            Console.WriteLine();
        }
    }
}

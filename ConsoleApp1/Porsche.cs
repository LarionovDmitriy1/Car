using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Porsche : Car
    {
        public Porsche()
        {
            _mark = "Porsche";
            _price = 500000;
            _speed = 500;
            _enginePower = 1000;
            _year = 1993;
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
            Console.WriteLine($"{_mark} поехала домой");
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

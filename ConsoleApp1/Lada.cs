using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lada : Car
    {

        public Lada()
        {
            _mark = "Lada";
            _price = 300000;
            _speed = 10000;
            _enginePower = 10000;
            _year = 2077;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Марка машины - {_mark}");
            Console.WriteLine($"Цена - {_price}");
            Console.WriteLine($"Максимальная скорость полёта - {_speed}");
            Console.WriteLine($"Мощность двигателя - {_enginePower}");
            Console.WriteLine($"Год выпуска - {_year}");
            Console.WriteLine();
        }

        public override void Ride()
        {
            Console.WriteLine($"{_mark} полетела");
        }

        public override void Upgrade()
        {
            _enginePower = _enginePower + 20;
            _speed = _speed + 10;
            _price = _price + 50000;
            Console.WriteLine($"Мощность двигателя у {_mark} увеличилось на 20, куда больше, мощность двигателя - {_enginePower}");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 
 

        internal class BMW : Car
        {
            public BMW()
            {
                _mark = "BMW";
                _price = 400000;
                _speed = 0;
                _enginePower = 2;
                _year = 2677;
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
                Console.WriteLine($"{_mark} стоит на СТО");
            }

            public override void Upgrade()
            {
                _enginePower = _enginePower + 20;
                _speed = _speed + 10;
                _price = _price + 50000;
                Console.WriteLine($"Мощность двигателя у {_mark} увеличилось на 20, но ехать не может, мощность двигателя - {_enginePower}");
                Console.WriteLine();
            }
        }
    }



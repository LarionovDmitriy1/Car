using ConsoleApp1;
using System;
using System.ComponentModel.Design;
User us = new User();
int money = 1000000;
while (true)
{
    Car Marks()
    {
        Console.WriteLine($"Ваш бюджет - {money}");
        Console.WriteLine();
        Console.WriteLine("1. BMW - цена 400000");
        Console.WriteLine("2. LADA - цена 300000 ");
        Console.WriteLine("3. MERCEDES-BENZ - цена 500000");
        Console.WriteLine("4. Porsche - цена 500000");
        Console.WriteLine();
        string select = Console.ReadLine();
        int select1 = int.Parse(select);
        if (select1 == 1)
        {
            if (money >= 400000)
            {
                Confirmed();
                money = money - 400000;

                Console.WriteLine($"Осталось денег - {money}");
                return new BMW();
            }
            else {
                Console.WriteLine($"Денег нехватает, баланс {money}") ;
            }
            

        }
        else if (select1 == 2)
        {
            if (money >= 300000)
            {
                Confirmed();
                money = money - 300000;

                Console.WriteLine($"Осталось денег - {money}");
                return new Lada();
            }
            else
            {
                Console.WriteLine($"Денег нехватает, баланс {money}");
            }
        }
        else if (select1 == 3)
        {
            if (money >= 500000)
            {
                Confirmed();
                money = money - 500000;

                Console.WriteLine($"Осталось денег - {money}");
                return new Mercedes();
            }
            else
            {
                Console.WriteLine($"Денег нехватает, баланс {money}");
            }
        }
        else if (select1 == 4)
        {
            if (money >= 500000)
            {
                Confirmed();
                money = money - 500000;

                Console.WriteLine($"Осталось денег - {money}");
                return new Porsche();
            }
            else
            {
                Console.WriteLine($"Денег нехватает, баланс {money}");
            }
        }
        return new BMW();
    }
    void Menu()
    {
        if (us.CheckCar() == false)
        {
            Console.WriteLine();
            Console.WriteLine("1. Купить авто");
            Console.WriteLine("2. Апгрейд авто");
            Console.WriteLine("3. получить инфо об авто");
            Console.WriteLine();
            string menu = Console.ReadLine();
            int menu1 = int.Parse(menu);

            if (menu1 == 1)
            {
                Car car = Marks();
                us.BuyCar(car);

            }

            else if (menu1 == 2)
            {


                Console.WriteLine();
                Console.WriteLine("Сначала купите машину");


            }

            else if (menu1 == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Сначала купите машину");

               

            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("1. Заменить авто");
            Console.WriteLine("2. Апгрейд авто");
            Console.WriteLine("3. получить инфо об авто");
            Console.WriteLine("4. Поехать");
            Console.WriteLine();
            string menu2 = Console.ReadLine();
            int menu3 = int.Parse(menu2);

            if (menu3 == 1)
            {
                Car car = Marks();
                us.BuyCar(car);

            }

            else if (menu3 == 2)
            {
                if (us.CheckCar() == true)
                {
                    if (money >= 50000)
                    {
                        Console.WriteLine();
                        us.UpgradeCar();
                        money = money - 50000;
                        Console.WriteLine($"Денег осталось - {money}");
                    }
                    else
                    {
                        Console.WriteLine($"Денег нехватает, баланс {money}");
                    }
                }

                

            }
            
            else if (menu3 == 3)
            {

                if (us.CheckCar() == true)
                {
                    Console.WriteLine();
                    us.GetInfo();
                }

                

            }
           else if (menu3 == 4)
            {
                us.Ride();   
            }
        }
       
    }
     Menu();
    void Confirmed()
    {
        Console.WriteLine("Вы уверены что хотите купить авто?");
        Console.WriteLine("1. Да");
        Console.WriteLine("2. Нет");
        string confirm = Console.ReadLine();
        int s = int.Parse(confirm);
        
         if (s == 1)
        {
            Console.WriteLine("Вы купили авто");
        }
        else if (s == 2)
        {
            Marks();
        }
    }
}

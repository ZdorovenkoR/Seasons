using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать метод по определению времени года. На вход подаётся число – порядковый номер
//месяца. На выходе — значение из перечисления (enum) — Winter, Spring, Summer,
//Autumn.Написать метод, принимающий на вход значение из этого перечисления и
//возвращающий название времени года (зима, весна, лето, осень). Используя эти методы,
//ввести с клавиатуры номер месяца и вывести название времени года. Если введено
//некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12»

namespace Seasons
{
    class Program
    {
        enum seasonsUser
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            var userMonth = Convert.ToInt32(Console.ReadLine());
            Seasons(userMonth);
           // Console.ReadKey();
        }
        static void Seasons (int userMonth)
        {
            switch (userMonth)
            {
                case 1:
                    Console.WriteLine(seasonsUser.Winter);
                    break;
                case 2:
                    Console.WriteLine(seasonsUser.Winter);
                    break;
                case 3:
                    Console.WriteLine(seasonsUser.Spring);
                    break;
                case 4:
                    Console.WriteLine(seasonsUser.Spring);
                    break;
                case 5:
                    Console.WriteLine(seasonsUser.Spring);
                    break;
                case 6:
                    Console.WriteLine(seasonsUser.Summer);
                    break;
                case 7:
                    Console.WriteLine(seasonsUser.Summer);
                    break;
                case 8:
                    Console.WriteLine(seasonsUser.Summer);
                    break;
                case 9:
                    Console.WriteLine(seasonsUser.Autumn);
                    break;
                case 10:
                    Console.WriteLine(seasonsUser.Autumn);
                    break;
                case 11:
                    Console.WriteLine(seasonsUser.Autumn);
                    break;
                case 12:
                    Console.WriteLine(seasonsUser.Winter);
                    break;
                default:
                    Console.WriteLine("Ошибка: введите значение от 1-12");
                    break;

            }
        }
    }
}

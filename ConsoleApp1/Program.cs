using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//godina
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var garden = new Garden
            {
                Owner = "Иванов Иван",
                Address = new Address { Street = "Ленина", City = "Москва" }
            };

            // Добавление цветов
            garden.Flowers.Add(new Flower { Title = "Роза", Description = "Красный цветок" });
            garden.Flowers.Add(new Flower { Title = "Тюльпан", Description = "Желтый цветок" });
            garden.Flowers.Add(new Flower { Title = "Лилия", Description = "Белый цветок" });

            // Показать все цветы
            garden.ShowAll();
            Console.ReadKey();
        }
    }
}

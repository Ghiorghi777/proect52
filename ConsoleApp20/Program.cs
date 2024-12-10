using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
    
        // Статический метод, который вычисляет количество сантиметров
        public static int Centimeters(int m, int c)
        {
            return (m * 100) + c;  // Преобразуем метры в сантиметры и добавляем дополнительные сантиметры
        }

        static void Main(string[] args)
        {
            // Пример а) 2 м 4 см
            int result1 = Centimeters(2, 4);
            Console.WriteLine("Количество сантиметров для 2 м 4 см: " + result1);  // Ожидаемый результат: 204

            // Пример б) 15 м 27 см
            int result2 = Centimeters(15, 27);
            Console.WriteLine("Количество сантиметров для 15 м 27 см: " + result2);  // Ожидаемый результат: 1527
            Console.ReadKey();
        }
    }
}


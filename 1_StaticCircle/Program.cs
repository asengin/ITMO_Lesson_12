using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_StaticCircle
{
    class Program
    {
        /*
         * Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
         * метод, определяющий длину окружности по заданному радиусу;
         * метод, определяющий площадь круга по заданному радиусу;
         * метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.
         */
        static void Main(string[] args)
        {
            #region Блок ввода данных
            Console.Write("Введите радиус окружности: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            if (radius < 0)
            {
                Console.WriteLine("Радиус не может быть отрицательным");
                Console.ReadKey();
                return; 
            }
            Console.WriteLine("Введите координаты центра окружности через Enter х0, у0: ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки через Enter х, у: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            #endregion
            Console.WriteLine($"Длина окружности: {Circle.Circumference(radius):f3}");
            Console.WriteLine($"Площадь окружности: {Circle.Sqr(radius):f3}");
            Console.WriteLine($"Точка с координатами [{x}, {y}] {Circle.PointInCircle(x0, y0, x, y, radius)} в окружность " +
                $"с радиусом {radius} и центром в точке [{x0}, {y0}]");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_60b
{
    public class Program
    {
        //функция проверки ввода вещественного числа
        public static double CheckInputDouble(string message, double minValue, double maxValue)
        //(сообщение, мин вводимое значение, макс вводимое значение)
        {
            double input; //переменная, которой будет присвоено значение, введенное с клавиатуры
            do
            {
                input = maxValue + 1;  //переменной присваивается значение, выходящее за макс значение
                Console.WriteLine(message); //печать сообщения
                try
                {
                    string buf = Console.ReadLine();
                    input = Convert.ToDouble(buf);
                }
                catch (FormatException)
                {
                }
                catch (OverflowException)
                {
                }
            } while ((input < minValue) || (input > maxValue)); //пока значение больше макс/меньше мин
            return input;
        }

        //функция, проверяющая принадлежит ли точка плоскости
        public static bool PointBelongsToPlane(double x, double y)
        {
            if ((x * x + y * y <= 1) & (y <= x / 2))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            //программа определяет u в зависимости от того принадлежит ли точка заданной плоскости

            double x, y;//входные данные - координаты точки
            double u;//выходные данные

            x=CheckInputDouble("Введите x",-Math.Pow(10, 5), Math.Pow(10, 5));//ввод значения с клавиатуры и проверка ввода
            y= CheckInputDouble("Введите y", -Math.Pow(10, 5), Math.Pow(10, 5));//ввод значения с клавиатуры и проверка ввода

            if (PointBelongsToPlane(x,y))//проверка принадлежности точки плоскости
                u = -3;
            else
                u = y * y;
            Console.WriteLine("u=" + u);//вывод результата


        }
    }
}

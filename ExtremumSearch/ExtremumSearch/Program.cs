using System;

namespace ExtremumSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GoldenRatio gr = new GoldenRatio();

            double eps = 0.0001; //Точность
            double a = -2; //Начало отрезка
            double b = 2; //Конец отрезка

            double max = gr.GetExtremumMax(Function, a, b, eps);
            double min = gr.GetExtremumMin(Function, a, b, eps);

            double dm = gr.DichotomyMethods(Function, a, b, eps);

            Console.WriteLine("Max: " + max + "  | Min: " + min + "  | Dichotomy: " + dm);

            Console.ReadKey();
        }

        static double Function(double x){ //Здесь изменять функцию
            return Math.Pow((x + 1), 3) + 5 * Math.Pow(x, 2);
        }
    }
}

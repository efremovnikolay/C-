using System;

namespace ExtremumSearch
{
    public class GoldenRatio
    {
        private double FI = (1 + Math.Sqrt(5)) / 2;
        private double x1, x2;

        public double GetExtremumMax(Func<double, double> Function, double a, double b, double eps){ //Точка максимума
            while (Math.Abs(b - a) > eps)
            {
                x1 = b - (b - a) / FI;
                x2 = a + (b - a) / FI;

                if (Function(x1) > Function(x2))
                    a = x1;
                else
                    b = x2;
            }
            return (a + b) / 2;
        }

        public double GetExtremumMin(Func<double, double> Function, double a, double b, double eps){ //Точка минимума
            while (Math.Abs(b - a) > eps)
            {
                x1 = b - (b - a) / FI;
                x2 = a + (b - a) / FI;

                if (Function(x1) < Function(x2))
                    a = x1;
                else
                    b = x2;
            }
            return (a + b) / 2;
        }
        //
        public double DichotomyMethods(Func<double, double> Function, double a, double b, double eps) { //Методы дихотомии
            double c;
            while ((b - a) > eps)
            {
                c = (a + b) / 2;
                if (Function(b) * Function(c) < 0)
                    a = c;
                else
                    b = c;
            }
            return (a + b) / 2;
        }
    }
}

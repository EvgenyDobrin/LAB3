using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yrav
{
    class Yravnenie
    {/// <summary>
     /// Приватные коэффициенты
     /// </summary>
        private double a, b, c;
        private double x1 = 0, x2 = 0;

        /// <summary>
        /// Конструктор параметров
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Yravnenie(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        /// <summary>
        /// Конструктор строк
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        public Yravnenie(string A, string B, string C)
        {
            bool fa = double.TryParse(A, out this.a);
            bool fb = double.TryParse(B, out this.b);
            bool fc = double.TryParse(C, out this.c);
            if (!(fa && fb && fc))
            {
                Excep ex = new Excep();
                ex.Excepen(fa, fb, fc, "Ошибка в значении");
            }
        }

        public double X1
        {
            get { return x1; }
        }

        public double X2
        {
            get { return x2; }
        }

        public double A
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }

        public double B
        {
            set
            {
                b = value;
            }
            get
            {
                return b;
            }
        }

        public double C
        {
            set
            {
                c = value;
            }
            get
            {
                return c;
            }
        }

        private double[] Otvet = new double[3];

        /// <summary>
        /// Метод, возвращающий ответ
        /// </summary>
        /// <returns></returns>
        public string Output()
        {
            double o = Otvet[0]; string otv = "";
            if (o == 1)
                return otv = "X-любое число.";
            else if (o == 2)
                return otv = "Один корень: " + Otvet[1].ToString("F0");
            else if (o == 3)
                return otv = "Первый корень: " + Otvet[1].ToString("F0") + "." + " Второй корень: " + Otvet[2].ToString("F0") + ".";
            else if (o == 4)
                return otv = "Нет корней.";
            else
                return otv = "Решений нет";
        }


        /// <summary>
        /// Решение квадратного уравнения
        /// </summary>
        public void Rechenie()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            double f;
            if ((a == 0) && (b == 0) && (c == 0)) Otvet[0] = 1;       //X-любое число
            else
            {
                if ((a == 0) && (b != 0) && (c != 0))
                {
                    x1 = -c / b;
                    Otvet[0] = 2; Otvet[1] = x1;                       //Один корень
                }
                if ((a != 0) && (b == 0) && (c != 0) && (-c / a > 0))
                {
                    f = c / a;
                    x1 = Math.Sqrt(Math.Abs(f));
                    x2 = -1 * Math.Sqrt(Math.Abs(f));
                    Otvet[0] = 3; Otvet[1] = x1; Otvet[2] = x2;          //Первый корень: " + x1 + "." + " Второй корень: " + x2
                }
                if ((a != 0) && (b == 0) && (c != 0) && (-c / a < 0))
                    Otvet[0] = 4;                                      //Корней нет
                if ((a != 0) && (b != 0) && (c == 0))
                {
                    x1 = 0;
                    x2 = -b / a;
                    Otvet[0] = 3; Otvet[1] = x1; Otvet[2] = x2;          //"Первый корень: " + x1 + "." + "Второй корень: " + x2
                }
                if ((a == 0) && (b == 0)) Otvet[0] = 5;                //Решений нет
                if ((a == 0) && (c == 0)) Otvet[0] = 2; Otvet[1] = x1;  //Корень: 0
                if ((b == 0) && (c == 0)) Otvet[0] = 2; Otvet[1] = x1;  //Корень: 0
                if ((a != 0) && (b != 0) && (c != 0))
                {
                    double d = b * b - 4 * a * c;
                    if (d > 0)
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        Otvet[0] = 3; Otvet[1] = x1; Otvet[2] = x2;      //Первый корень: " + x1 + "." + "Второй корень: " + x2
                    }
                    if (d == 0)
                    {
                        x1 = (-b / (2 * a));
                        Otvet[0] = 2; Otvet[1] = x1;                    //"Существует один корень: " + x1
                    }
                    if (d < 0)
                        Otvet[0] = 4;                                  //Нет корней.
                }
            }
        }

    }
}

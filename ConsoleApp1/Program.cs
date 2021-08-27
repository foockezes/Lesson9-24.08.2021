using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a2 = "NuN";
            Console.WriteLine("Введите валюту usd, euro, rub, som");
            string a1 = Console.ReadLine();
            if (a1 == "som")
            {
                Console.WriteLine("введите вторую волюту usd, euro, rub");
                a2 = Console.ReadLine();
            }
            Console.WriteLine("введите сумму конвертации");
            double s = Convert.ToDouble(Console.ReadLine());
                Converter conv = new Converter()
            {
                m1 = a1,
                sum = s,
                m2 = a2
            };
            conv.GetConv();
        }
    }
    class Converter
    {
        public string m1;
        public string m2;
        public double conver;
        public double sum;
        public Converter() { }
        public Converter(string M1, string M2, double Sum)
        {
           m1 = M1; m2 = M2; conver = Sum;
        }
        public void GetConv()
        {
            if (m1 == "usd")
            {
                conver = sum * 1143.86 / 100;
                Console.WriteLine($"{sum} дол равняется {Math.Round(conver, 2)} сом");
            }
            else if (m1 == "som" && m2 == "usd")
            {
                conver = sum * 8.74 / 100;
                Console.WriteLine($"{sum} сом равняется {Math.Round(conver, 2)} дол");
            }
            else if (m1 == "euro")
            {
                conver = sum * 1345.52 / 100;
                Console.WriteLine($"{sum} эвро равняется {Math.Round(conver, 2)} сом");
            }
            else if (m1 == "som" && m2 == "euro")
            {
                conver = sum * 7.44 / 100;
                Console.WriteLine($"{sum} сом равняется {Math.Round(conver, 2)} эвро");
            }
            else if (m1 == "rub")
            {
                conver = sum * 15.45 / 100;
                Console.WriteLine($"{sum} руб равняется {Math.Round(conver, 2)} сом");
            }
            else if (m1 == "som" && m2 == "rub")
            {
                conver = sum * 647.60 / 100;
                Console.WriteLine($"{sum} сом равняется {Math.Round(conver, 2)} эвро");
            }
            else Console.WriteLine("Введен не правильное значение");
        }
    }
}
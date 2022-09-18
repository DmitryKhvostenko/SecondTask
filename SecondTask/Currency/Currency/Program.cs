using System;

namespace Currency
{
    class Courses
    {
        public double usd = 36.49;
        public double eur = 36.55;
        public double rub = 0.60;
    }
    class Calc
    {
        static void Main()
        {
            Courses course = new Courses();
            string FirstCurrency;
            string CurrencyAmount;
            double Result = 0;
            double CurrencyAmount2;
            string SecondCurrency;
            Console.WriteLine("Какую валюту вы хотите обменять? usd/eur/rub/uan");
            FirstCurrency = Console.ReadLine();
            if (FirstCurrency != "usd" && FirstCurrency != "eur" && FirstCurrency != "rub" && FirstCurrency != "uan") { Console.WriteLine("Ошибка! Неправильный выбор валюты."); return; }
            Console.WriteLine("Сколько валюты вы хотите обменять?");
            CurrencyAmount = Console.ReadLine();
            CurrencyAmount2 = Convert.ToDouble(CurrencyAmount);
            if (CurrencyAmount2 < 0) { Console.WriteLine("Число должно быть больше нуля!"); return; }
            if (FirstCurrency == "usd")
            {
                Result = CurrencyAmount2 * course.usd;
                Result = Math.Round(Result, 1);
                Console.WriteLine(CurrencyAmount2 + " USD = " + Result + " UAN");
            }
            if (FirstCurrency == "eur")
            {
                Result = CurrencyAmount2 * course.eur;
                Result = Math.Round(Result, 1);
                Console.WriteLine(CurrencyAmount2 + " EUR = " + Result + " UAN");
            }
            if (FirstCurrency == "rub")
            {
                Result = CurrencyAmount2 * course.rub;
                Result = Math.Round(Result, 1);
                Console.WriteLine(CurrencyAmount2 + " RUB = " + Result + " UAN");
            }
            if (FirstCurrency == "uan")
            {
                Console.WriteLine("На какую валюту вы хотите обменять? usd/eur/rub");
                SecondCurrency = Console.ReadLine();

                if (SecondCurrency == "usd")
                {
                    Result = CurrencyAmount2 / course.usd;
                    Result = Math.Round(Result, 2);
                    Console.WriteLine(CurrencyAmount2 + " UAN = " + Result + " USD");

                }
                if (SecondCurrency == "eur")
                {
                    Result = CurrencyAmount2 / course.eur;
                    Result = Math.Round(Result, 2);
                    Console.WriteLine(CurrencyAmount2 + " UAN = " + Result + " EUR");

                }
                if (SecondCurrency == "rub")
                {
                    Result = CurrencyAmount2 / course.rub;
                    Result = Math.Round(Result, 2);
                    Console.WriteLine(CurrencyAmount2 + " UAN = " + Result + " RUB");
                }
            }
        }
    }
}
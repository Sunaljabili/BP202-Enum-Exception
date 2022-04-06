using Classwork.Enum;
using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exchange(Currency.Usd,20));
            Console.WriteLine(Exchange(Currency.Eur,20));
            Console.WriteLine(Exchange(Currency.Rub,20));
            Console.WriteLine(Exchange(Currency.Try, 20));
        }

        public static double Exchange(Currency currency,double azn)
        {
            switch (currency)
            {
                case Currency.Usd:
                    return azn * 0.59 ;
                case Currency.Eur:
                    return azn * 0.52;
                case Currency.Try:
                    return azn * 8.62;
                case Currency.Rub:
                    return azn * 48.78;
                default:
                    return 0;
            }
        }
    }
}

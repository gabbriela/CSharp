using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Temperature
{
    class Temperature
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }
    }
    class StartUp
    {
        static void Main(string[] args)
        {
            const string endOfInput = "End";
            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != endOfInput)
            {
                if (input[1] == "Celsius")
                {
                    Console.WriteLine($"{Temperature.CelsiusToFahrenheit(double.Parse(input[0])):f2} Fahrenheit");
                }
                else
                {
                    Console.WriteLine($"{Temperature.FahrenheitToCelsius(double.Parse(input[0])):f2} Celsius");
                }

                input = Console.ReadLine().Split(' ');
            }
        }
    }
}

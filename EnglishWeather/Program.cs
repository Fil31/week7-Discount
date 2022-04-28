using System;

namespace EnglishWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            //temp < 0 Freezing cold
            //temp 0-10 Very cold
            //temp 10-20 Cold
            //temp 20-30 Warm
            //temp 30-35 Hot
            //>= 35 Boiling hot
            // приложение позволяет пользователю ввести текущую температуру воздуха (по цельсию)
            // приложение отвечает, как назвать температуру в данном диапазоне на английском
            int currentTemp;
            Console.WriteLine("Enter the temperature:");
            currentTemp = Convert.ToInt32(Console.ReadLine());

            if(currentTemp < 0)
            {
                Console.WriteLine("Freezing cold");
            }
            else if (currentTemp >= 0 && currentTemp <= 10)
            {
                Console.WriteLine("Very cold");
            }    
            else if (currentTemp >=10 && currentTemp <= 20)
            {
                Console.WriteLine("Cold");
            }
            else if (currentTemp >=20 && currentTemp <=30)
            {
                Console.WriteLine("Warm");
            }
            else if (currentTemp >=30 && currentTemp <=35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("Boiling hot");
            }
        }
    }
}

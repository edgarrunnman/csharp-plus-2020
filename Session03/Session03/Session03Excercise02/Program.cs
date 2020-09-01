using System;
using System.Diagnostics;
using System.Globalization;

namespace Session03Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konvertera det inmatade värdena från strängar till siffror
            // Resultatet skall presentera:
            // Lägsta värdet
            // Högsta värdet
            // Medelvärde (snitt)
            // Programmet skall vara felhanterat
            // Felaktiga värden får inte påverka medelvärde, lägsta eller högsta.

            while (true)
            {
                Console.WriteLine("Ange ett antal siffror, separerat med mellanslag.");
                string input = Console.ReadLine();
                string[] inputArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                double sum = 0;
                double highestValue = 0;
                double lowestValue = 0;
                int countOfNumbers = 0;
                double?[] numberArray = new double?[inputArray.Length];

                for (int i = 0; i < inputArray.Length; i++)
                {
                    bool parsed = double.TryParse(inputArray[i], out double parsedValue);

                    if (parsed)
                    { 
                        highestValue = parsedValue;
                        lowestValue = parsedValue;
                        numberArray[i] = parsedValue;
                        countOfNumbers++;
                    }
                    else numberArray[i] = null;

                }

                foreach (var number in numberArray)
                {
                    if (number != null)
                    {
                        sum += (double)number;
                        foreach (var number2 in numberArray)
                        {
                            if ((number > number2) && (number > highestValue)) highestValue = (double)number;
                            if ((number < number2) && (number < lowestValue)) lowestValue = (double)number;
                        }
                    }
                }
                double average = sum / countOfNumbers;
                Console.WriteLine("medelvärde är: " + average);
                Console.WriteLine("högsta värde är: " + highestValue);
                Console.WriteLine("lägsta värde är: " + lowestValue);
            }
        }
    }
}

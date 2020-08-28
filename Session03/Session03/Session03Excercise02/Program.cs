using System;

namespace Session03Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            double?[] numberArray = new double?[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool parsed = double.TryParse(inputArray[i], out double parsedValue);
                if (parsed) numberArray[i] = parsedValue;
                else numberArray[i] = null;

            }
            double highestValue = (double)numberArray[0];
            double lowestValue = (double)numberArray[0];


            foreach (var number in numberArray)
            {
                if (number != null)
                {
                    sum += (double)number;
                    foreach (var number2 in numberArray)
                    {
                        if ((number > number2) & (number > highestValue)) highestValue = (double)number;
                        if ((number < number2) & (number < lowestValue)) lowestValue = (double)number;
                    }
                }
            }
            double average = sum / inputArray.Length;
            Console.WriteLine("medelvärde är: " + average);
            Console.WriteLine("högsta värde är: " + highestValue);
            Console.WriteLine("lägsta värde är: " + lowestValue);
            Console.ReadKey();
        }
    }
}

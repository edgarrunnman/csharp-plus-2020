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

            double[] numberArray = new double[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                try
                {
                    numberArray[i] = Convert.ToDouble(inputArray[i]);
                }
                catch (Exception)
                {
                    numberArray[i] = 0;
                }
            }

            double highestValue = numberArray[0];
            double lowestValue = numberArray[0];

            foreach (var number in numberArray)
            {
                sum += number;
                foreach(var number2 in numberArray)
                {
                    if ((number > number2) & (number > highestValue)) highestValue = number;
                    if ((number < number2) & (number < lowestValue)) lowestValue = number;
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

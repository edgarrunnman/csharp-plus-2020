using System;

namespace Session03Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            var sum = 0m;
            int highestValue = Convert.ToInt32(inputArray[0]);
            int lowestValue = Convert.ToInt32(inputArray[0]);
            foreach (var number in inputArray)
            {
                int numberInteger = Convert.ToInt32(number);
                sum += numberInteger;

                foreach (var number2 in inputArray)
                {
                    int numberInteger2 = Convert.ToInt32(number2);
                    if ((numberInteger > numberInteger2) & (numberInteger > highestValue)) highestValue = numberInteger;
                    if ((numberInteger < numberInteger2) & (numberInteger < lowestValue)) lowestValue = numberInteger;
                }
            }
            var average = sum / inputArray.Length;
            Console.WriteLine("medelvärde är: " + average);
            Console.WriteLine("högsta värde är: " + highestValue);
            Console.WriteLine("lägsta värde är: " + lowestValue);
            Console.ReadKey();
        }
    }
}

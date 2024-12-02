using System;

class Program
{
    static void Main(string[] args)
    {
        double[] temperatures = new double[5];
        bool isIncreasing = true;
        bool isDecreasing = true;

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (true)
            {
                Console.Write($"Enter temperature {i + 1} (between −30 and 130): ");
                if (double.TryParse(Console.ReadLine(), out double temp) && temp >= -30 && temp <= 130)
                {
                    temperatures[i] = temp;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a temperature between −30 and 130.");
                }
            }
        }

        for (int i = 1; i < temperatures.Length; i++)
        {
            if (temperatures[i] > temperatures[i - 1])
            {
                isDecreasing = false;
            }
            else if (temperatures[i] < temperatures[i - 1])
            {
                isIncreasing = false;
            }
        }


        if (isIncreasing)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (isDecreasing)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It’s a mixed bag");
        }


        Console.WriteLine("\nTemperatures entered:");
        foreach (double temp in temperatures)
        {
            Console.WriteLine(temp);
        }

        double sum = 0;
        foreach (double temp in temperatures)
        {
            sum += temp;
        }
        double average = sum / temperatures.Length;
        Console.WriteLine($"\nAverage temperature: {average:F2}");
    }
}
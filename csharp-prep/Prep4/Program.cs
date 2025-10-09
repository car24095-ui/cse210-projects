using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<float> list = new List<float>();
        float sum = 0;
        float average = 0;
        float big = 0;
        float number = -1;

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = float.Parse(Console.ReadLine());

            if (number != 0)
            {
                list.Add(number);

            }
        }

        foreach (float f in list)
        {
            sum += f;
        }
        foreach (float f in list)
        {
            if (f > big)
            {
                big = f;
            }
        }
        average = sum / list.Count;

        Console.WriteLine($"The total is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {big}");
        


    }
}
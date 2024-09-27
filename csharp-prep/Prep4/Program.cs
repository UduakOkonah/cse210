using System;

class Program
{
    static void Main(string[] args)
    {
         // Step 1: Initialize a list to store the numbers
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userInput = -1; // To start the loop

        // Step 2: Ask the user for numbers until they enter 0
        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            // Only add the number to the list if it's not 0
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        // Step 3: Compute the sum of the numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Step 4: Compute the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Step 5: Find the maximum number
        int maxNumber = numbers[0]; // Start with the first number
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {maxNumber}");

        // Step 6: Find the smallest positive number
        int? smallestPositive = null;

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (smallestPositive == null || number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        }

        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        // Step 7: Sort the list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        // Determine the letter grade
        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the grade sign
        int lastDigit = percentage % 10;

        if (letter != "F") // Only add sign for non-F grades
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special case: A+ does not exist
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // Special case: No F+ or F-
        if (letter == "F")
        {
            sign = "";
        }

        // Display the final letter grade with the sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Determine if the user passed or failed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Better luck next time!");
        }
    }
}
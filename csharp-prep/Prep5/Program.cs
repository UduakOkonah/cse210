using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);
        int cubedNumber = CubeNumber(userNumber); // Additional functionality to cube the number

        DisplayResult(userName, squaredNumber, cubedNumber); // Passing both square and cube
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static int CubeNumber(int number) // New function to cube the number
    {
        int cube = number * number * number;
        return cube;
    }

    static void DisplayResult(string name, int square, int cube) // Updated to show both square and cube
    {
        Console.WriteLine($"{name}, the square of your number is {square} and the cube of your number is {cube}");
    }
}
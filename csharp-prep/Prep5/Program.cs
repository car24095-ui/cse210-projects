using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        int i;
        Console.Write("What is your favorite number? ");
        i = int.Parse(Console.ReadLine());
        return i;
    }
    static int PromptUserBirthYear(out int birthYear)
    {
        Console.Write("What year were you born? ");
        birthYear = int.Parse(Console.ReadLine());
        return birthYear;
    }
    static int SquareNumber(int i)
    {
        i = i * i;
        return i;
    }
    static void DisplayResult(string name, int i, int birthYear)
    {
        Console.WriteLine($"{name}, your number squared is: {i}\n{name}, you will be {(2025 - birthYear) + 1} this year!");

    }
    static void Main(string[] args)
    {
        int x = 0;
        DisplayWelcome();
        string a = PromptUserName();
        int c = PromptUserNumber();
        PromptUserBirthYear(out x);
        int b = SquareNumber(c);
        
        DisplayResult(a, b, x);


    }
}
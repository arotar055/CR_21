using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
       Console.WriteLine("Enter surname with initials (e.g., Rotar A.A. or Rotar A.M):");
        string nameInput = Console.ReadLine();
        if (IsValidName(nameInput))
            Console.WriteLine("Name format is correct.");
        else
            Console.WriteLine("Invalid name format.");

        Console.WriteLine("\nEnter email (e.g., user055@email.com):");
        string emailInput = Console.ReadLine();
        if (IsValidEmail(emailInput))
            Console.WriteLine("Email format is correct.");
        else
            Console.WriteLine("Invalid email format.");

        Console.WriteLine("\nEnter date (e.g., 01-04-2015):");
        string dateInput = Console.ReadLine();
        if (IsValidDate(dateInput))
            Console.WriteLine("Date format is correct.");
        else
            Console.WriteLine("Invalid date format.");
    }

    static bool IsValidName(string input)
    {
        string pattern = @"^([А-ЯЁA-Z][а-яёa-z]+) ([А-ЯЁA-Z]\.[А-ЯЁA-Z]\.|[А-ЯЁA-Z]{2})$";
        return Regex.IsMatch(input, pattern);
    }

    static bool IsValidEmail(string input)
    {
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{2,15}@[A-Za-z0-9]+(\.[A-Za-z0-9]+)*\.[A-Za-z]{2,3}$";
            return Regex.IsMatch(input, pattern);
    }

    static bool IsValidDate(string input)
    {
        string pattern = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-(19|20)\d{2}$";
        return Regex.IsMatch(input, pattern);
    }
}

using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("What year where you born in?");
        string stringBirthYear = Console.ReadLine();
        int birthyear = int.Parse(stringBirthYear);

        Console.WriteLine("You where alive during these leap years:");
        for (int year = birthyear; year <=2020; year ++)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine(year);
            }
        }
    }
}
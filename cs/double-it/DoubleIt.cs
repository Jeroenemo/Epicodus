using System;

class DoubleIt
{
    static void Main()
    {
        Console.WriteLine("Give me a number and I'll double it for you!");
        string stringNumber = Console.ReadLine();
        int yourNumber = int.Parse(stringNumber);
        int yourDoubledNumber = yourNumber * 2;
        string stringDoubledNubmber = yourDoubledNumber.ToString();
        Console.WriteLine("Your doubled number is: " + yourDoubledNumber);

    }
}
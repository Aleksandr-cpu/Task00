using System;
using System.Reflection;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        // Введите свое решение ниже
        if (number < 10000 || number > 99999)
        {
            Console.WriteLine($"{number} -> Число не пятизначное");
            return false;
        }

        int originalNumber = number;
        int reverseNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverseNumber = reverseNumber * 10 + digit;
            number = number / 10;
        }

        if (originalNumber == reverseNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}

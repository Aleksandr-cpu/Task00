using System;

public class Answer
{
    public static double FindMax(double[] array)
    {     // Введите свое решение ниже
        double maxNumber = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxNumber) maxNumber = array[i];
        }
        return maxNumber;
    }

    public static double FindMin(double[] array)
    {     // Введите свое решение ниже
        double minNumber = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minNumber) minNumber = array[i];
        }
        return minNumber;


    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {// Введите свое решение ниже
        double maxNum = array[0];
        double minNum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxNum) maxNum = array[i];
            if (array[i] < minNum) minNum = array[i];
        }
        double result = maxNum - minNum;
        return result;
    }

    public static void PrintArray(double[] array)
    {// Введите свое решение ниже
        foreach (double number in array)
        {
            Console.Write($"{number}\t");
        }
        Console.WriteLine();

    }
    // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}
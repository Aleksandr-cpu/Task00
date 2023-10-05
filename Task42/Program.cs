// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10





// string DecToBin2(int num)
// {
//     int resolt = num / 2;
// }

int DecToBaseNum(int num, int baseNum)
{
    int result = 0;
    int mult = 1;
    while (num > 0)
    {
        result += num % baseNum * mult;
        num /= baseNum;
        mult *= 10;
    }
    return result;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите основание системы счисления: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());

int res = DecToBaseNum(number, baseNumber);
Console.WriteLine($"{number}, {baseNumber} -> {res}");

// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да




Console.WriteLine($"Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool MultipleOfTwoNumbers(int num)
{
    bool multiple = num % 7 == 0 && num % 23 == 0;
    return multiple;
}

bool result = MultipleOfTwoNumbers(number);

Console.WriteLine(result ? "Да" : "Нет");
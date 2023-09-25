

int num = 3582387; // 3582387 / 10 =358238 / 10 = 35823 / 10 = 3582 / 10 = 358 % 10 = 8

// while(num > 999)
// {
//     num /=10;
// }
// Console.WriteLine(num % 10);

int res = GetThirdDigit(num);
Console.WriteLine(res);
int GetThirdDigit(int number)
{
    while(num > 999) num /= 10;
    return num % 10;
}
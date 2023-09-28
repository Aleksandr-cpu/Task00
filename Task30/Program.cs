// int[] array = new int[8]; // 0 1 2 3 4 5 6 7

// int[] array1 = new int[8] { 4, 7, 8, 9, 2, 3, 4, 8 };
// int[] array2 = new int[] { 4, 7, 8, 9, 2, 3, 4, 8 };

// var array4 = new int[8] { 4, 7, 8, 9, 2, 3, 4, 8 };

// // var n = 5 / 3 + 7 / 11 + 45; нельзя использовать, так как потеряем данные. получается с остатком. система по умолчанию использует int32
// // [] - обозначение массива. используется для любых типов

// array[0] = 456;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
//     Console.Write(array[i] + " ");
// }




// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] arr = CreateArray(8);
PrintArray(arr);





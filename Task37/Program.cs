// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.Clear();

int siz = Prompt("Введите длинну массива");
int minValue = Prompt("Введите минимальное число для массива");
int maxValue = Prompt("Введите максимальное число для массива");
int[] array = CreateArray(siz, minValue, maxValue);
SeeArray(array, ",");
int[] mulArr = MultiPairs(array);
Console.Write("-> ");
SeeArray(mulArr, ",");
Console.WriteLine();





int Prompt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[] CreateArray(int size, int minV, int maxV)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minV, maxV + 1);
    }
    return arr;
}

void SeeArray(int[] arr, string sep)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.Write($"{arr[arr.Length - 1]} ");
    Console.Write("] ");
}

// int[] MultiPairs(int[] arr)
// {
//     int[] multArr = new int[arr.Length / 2];
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         multArr[i] = arr[i] * arr[arr.Length - i];
//     }
//     return multArr;
// }
int[] MultiPairs(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    int[] multArr = new int[size];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        multArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    //    if(arr.Length % 2 == 1) newArr[size - 1] = arr[arr.Length/2];
    return multArr;
}
// rnd.NextDouble() * (maxValue - minValue) + minValue
// arr[i] = Math.Round(NativeOverlapped , 1) 

// double[] CreateArrayRndDouble(int size, int min, int max)
/* {
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}
void PrintArrayDouble(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
} */
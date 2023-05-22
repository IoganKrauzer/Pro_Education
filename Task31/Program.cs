/* Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
 */

Console.Clear();

int[] array = CreateArr(12, -9, 9);
SeeArray(array, ",");
// int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
// Console.WriteLine($"Сумма положительных элементов равна {getSumPositiveNegativeElem[0]}");
// Console.WriteLine($"Сумма отрицательных элементов равна {getSumPositiveNegativeElem[1]}");

int suMax = SumNumbers (array, "+");
int suMin = SumNumbers (array, "-");
Console.WriteLine("Сумма положительных чисел равна " + suMax);
Console.WriteLine("Сумма отрицательных чисел равна " + suMin);

// int[] GetSumPositiveNegativeElem(int[] arr)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//             sumPositive += arr[i];
//         else
//             sumNegative += arr[i];
//     }
//     return new int[2]{sumPositive, sumNegative};

// }

int[] CreateArr(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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
    Console.WriteLine("]\n");
}

int SumNumbers (int[] arr, string plus)

{
    int sumMinNumb = 0;
    int sumMaxNumb = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) sumMaxNumb += arr[i];
    if (arr[i] < 0) sumMinNumb += arr[i];
}
if (plus == "+" ) return sumMaxNumb;
else return sumMinNumb;

}

// Console.WriteLine("Сумма всех максимальных числе в массиве равна    " + sumMaxNumb);
// Console.WriteLine("Сумма всех отрицательных числе в массиве равна   " + sumMinNumb);
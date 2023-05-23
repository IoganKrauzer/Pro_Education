// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Console.Clear();
int arrLength = Prompt("Введите длинну массива");
int minValue = Prompt("Введите минимальное число массива");
int maxValue = Prompt("Введите максимальное число массива");

double[] array = CreateDoubleArray(arrLength, minValue, maxValue);
double[] getMinAndMaxElemInArray = GetMinAndMaxElemInArray(array);
double minElemInArray = getMinAndMaxElemInArray[0];
double maxElemInArray = getMinAndMaxElemInArray[1];
Console.Write("[");
SeeDoubleArray(array, ",");
Console.Write("] ");
Console.Write($"-> {Math.Round(DeductionMinFromMax(array, minElemInArray, maxElemInArray), 1)}\n");
Console.WriteLine();
Console.Write($"Разница между максимальным элементом массива {maxElemInArray} и "
            + $" минимальным элементом {minElemInArray}"
            + $" составляет: {Math.Round(DeductionMinFromMax(array, minElemInArray, maxElemInArray), 1)}\n");



int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] CreateDoubleArray(int size, int minV, int maxV)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (maxV - minV) + minV;
    }
    return arr;
}

double[] GetMinAndMaxElemInArray(double[] arr)
{
    double minElem = arr[0];
    double maxElem = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElem) minElem = arr[i];
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElem) maxElem = arr[i];
    }

    return new double[2] { minElem, maxElem };
}

double DeductionMinFromMax(double[] arr, double minElem, double maxElem)
{
    double deduction = maxElem - minElem;
    return deduction;
}

void SeeDoubleArray(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)}{sep} ");
    }
    Console.Write($"{Math.Round(arr[arr.Length - 1], 1, MidpointRounding.ToZero)}");
}
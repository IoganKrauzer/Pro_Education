/* // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

int arrLength = Prompt("Введите длинну массива");
int minValue = Prompt("Введите минимальное число массива");
int maxValue = Prompt("Введите максимальное число массива");

double[] array = CreateArray(arrLength, minValue, maxValue);
SeeArray(array, ",");
Console.WriteLine("\n");
SeeArray2(array, ",");
Console.WriteLine("\n");

double minElemOfArray = FindMinOrMaxElemInArray(array, "-");
Console.WriteLine(minElemOfArray);
Console.WriteLine(Math.Round(minElemOfArray, 1, MidpointRounding.ToZero));
double maxElemOfArray = FindMinOrMaxElemInArray(array, "+");
Console.WriteLine(maxElemOfArray);
Console.WriteLine(Math.Round(maxElemOfArray, 1, MidpointRounding.ToZero));
double deductionMinFromMax = Math.Round(DeductionMinFromMax(array, minElemOfArray, maxElemOfArray), 1, MidpointRounding.ToZero);
Console.Write($"Разница {maxElemOfArray} и {minElemOfArray} равняется: {deductionMinFromMax}\n");










int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] CreateArray(int size, int minV, int maxV)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (maxV - minV) + minV;

    }
    return arr;
}

void SeeArray(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
}

double FindMinOrMaxElemInArray(double[] arr, string searchElem)
{
    double minElem = 0;
    double maxElem = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] > arr[i + 1]) minElem = arr[i];
        if (arr[i] < arr[i + 1]) maxElem = arr[i];
    }
    if (searchElem == "+") return maxElem;
    else return minElem;
}

double DeductionMinFromMax(double[] arr, double minElem, double maxElem)
{
    double deduction = maxElem - minElem;
   
    return deduction;

}

void SeeArray2(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero) }{sep} ");
    }
    Console.Write($"{Math.Round(arr[arr.Length - 1], 1,MidpointRounding.ToZero)}");
} */
// Задача 38: 
// 1. Задайте массив вещественных чисел.
// 2.  Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");  // для точки в вещественных числах

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());


double[] array = CreateArrayRndInt(size, 1, 10);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
double[] arrayDeductionMinFromMax = DifferenceMaxMin(array);
double minElem = Math.Round(arrayDeductionMinFromMax[0], 1);
double maxElem = Math.Round(arrayDeductionMinFromMax[1], 1);


Console.WriteLine($"всего {size} чисел. Максимальное значение = {maxElem }, минимальное значение = {minElem}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {Math.Round(maxElem - minElem, 1)}");






double[] CreateArrayRndInt(int siz, int min, int max)
{
    double[] arr = new double[siz];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + max;
    }
    return arr;
}


void PrintArray(double[] arr, string sep = ",") //sep - параметр для разделения (запятая и прочие)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round((arr[i]), 1)}{sep} ");
        else Console.Write($"{Math.Round((arr[i]), 1)}");
    }
}

double[] DifferenceMaxMin(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return new double[] { min, max };
}
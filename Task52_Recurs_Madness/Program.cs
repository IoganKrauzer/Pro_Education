/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


Console.Clear();

int rows = Prompt("Введите количество строк для двумерного массива");
int columns = Prompt("Введите количество столбцов для двумерного массива");
int minValue = Prompt("Введите минимальное число для заполнения массива");
int maxValue = Prompt("Введите максимальное число для заполнения массива");

int[,] array2d = CreatMatrixRndInt(rows, columns, minValue, maxValue);
PrintMatrixArray(array2d);
double[] array = CreateDoubleArrayForSumOfColumns(columns);
array = AverageSumofColumns(array, array2d);
Console.WriteLine("Среднее арифметичское каждого столбца: ");
PrintArray(array);




int RecursionToFindColumnsSum(int[,] arr, int row = 0, int col = 0)
{

    if (row >= arr.GetLength(0)) return 0;
    return arr[row, col] + RecursionToFindColumnsSum(arr, row + 1, col);
}


double[] AverageSumofColumns (double [] ar, int[,] arr, int row = 0, int col = 0)
{
    double sumOfColums = 0;
    for (col = 0; col < arr.GetLength(1); col++)
    {
      sumOfColums = RecursionToFindColumnsSum( arr,  row , col );
     ar[col] = Math.Round(sumOfColums / arr.GetLength(0), 1) ;
    }
return ar;
}


int[,] CreatMatrixRndInt(int row, int col, int minV, int maxV)
{
    int[,] arr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(minV, maxV + 1);
        }
    }
    return arr;
}


void PrintMatrixArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


void PrintArray(double[] ar, char sep = ';')
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.WriteLine($"Столбец {i + 1}-й:  {ar[i]}{sep} ");
    }
    Console.WriteLine("\n");
}


double[] CreateDoubleArrayForSumOfColumns(int size)
{
    double[] ar = new double[size];
    return ar;
}
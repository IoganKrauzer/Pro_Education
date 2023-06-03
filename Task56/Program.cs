// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] array2d = CreatMatrixRndInt(4, 4, 1, 9);
PrintMatrixArray(array2d);
int[] sumOfRowsArr = SumOfRowsInArray2d(array2d);
PrintArray(sumOfRowsArr);         
Console.WriteLine($@"Строка с наименьшей суммой № {RowWithLessSum(sumOfRowsArr) + 1}" + "\n"
             +$"Сумма элементов строки: {sumOfRowsArr[RowWithLessSum(sumOfRowsArr)]}"+ "\n");






int RowWithLessSum (int[] ar)
{
    int lessSumIndex = 0;
    for (int i = 1; i < ar.Length; i++)
    {
        if (ar[lessSumIndex] > ar[i]) lessSumIndex = i;
    }
    return lessSumIndex;
}


int[] SumOfRowsInArray2d(int[,] arr)
{
    int[] sumOfRowsArr = new int[arr.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        sumOfRowsArr[i] = sum;
        sum = 0;
    }
    return sumOfRowsArr;
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


void PrintArray(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
       
            Console.Write($"{ar[i],5} ");
    }
    Console.WriteLine();
}
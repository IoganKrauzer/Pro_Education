/* Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

 */
Console.Clear();

int[,] array2d = CreatMatrixRndInt(5, 5);
PrintMatrixArray(array2d);
Console.WriteLine("\n");
SumRowEqColumns(array2d);
Console.WriteLine($"Сумма по диагонали: {SumRowEqColumns(array2d)}");





int[,] CreatMatrixRndInt(int row, int col, int minV = -10, int maxV = 10)
{
    int[,] arr = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(minV, maxV);
        }
    }
    return arr;
}

int SumRowEqColumns(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j) sum += arr[i, j];

        }
    }
    return sum;
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
}

/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2  В итоге получается вот такой массив:      7 4 2 1
5 9 2 3                                            9 5 3 2
8 4 2 4                                            8 4 4 2

 */

Console.Clear();

int[,] array2d = CreatMatrixRndInt(4, 4, 1, 9);
PrintMatrixArray(array2d);
UsingSortByChoiceFromMaxToMinInRowInMatrixArray(array2d);
PrintMatrixArray(array2d);






void UsingSortByChoiceFromMaxToMinInRowInMatrixArray(int[,] arr)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            int max = j;
            for (int k = j + 1; k < array2d.GetLength(1); k++)
            {
                if (array2d[i, max] < array2d[i, k]) max = k;
            }
            if (array2d[i, j] < array2d[i, max])
            {
                int temp = array2d[i, j];
                array2d[i, j] = array2d[i, max];
                array2d[i, max] = temp;
            }
        }
    }
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
﻿/* Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Amn = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

Console.Clear();

int[,] array2d = CreatMatrixRndInt(3, 4);     //  array2d
PrintMatrixArray(array2d);







int[,] CreatMatrixRndInt(int row, int col)
{
    int[,] arr = new int[row, col];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
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
            Console.Write($"{arr[i, j], 2} ");
        }
        Console.WriteLine();
    }
}

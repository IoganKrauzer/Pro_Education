/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

                                           // ТОЛЬКО ДЛЯ МАТРИЦЫ 4*4 РАБОТАЕТ 
int[,] array2d = new int[4,4];
SpiralFillArray(array2d);
PrintMatrixArray(array2d);

void SpiralFillArray(int[,] arr)
{
    int top = 0;
    int bot = arr.GetLength(0) - 1;
    int left = 0;
    int right = arr.GetLength(1) - 1;
    int fillNum = 1;
    for (int i = top; i <= right; i++)
    {
        arr[top, i] = fillNum ;
        fillNum++;
    }
    top++;
    for (int j = top; j <= bot; j++)
    {
        arr[j, right] = fillNum ;
        fillNum++;
    }
    for (int k = right - 1; k >= left; k--)
    {
        arr[bot, k] = fillNum ;
        fillNum++;
    }
    for (int p = bot - 1; p >= top; p--)
    {
        arr[p, left] = fillNum ;
        fillNum++;
    }
    for (int m = left + 1; m < right; m++)
    {
        arr[top, m] = fillNum;
        fillNum++;
    }
    for (int t = top + 1; t < bot; t++)
    {
        arr[t, right - 1] = fillNum;
        fillNum++;
    }
    for (int end = left + 1; end > left; end--)
    {
        arr[bot - 1, end] = fillNum ;
    }
}












/* void SpiralFillArray(int[,] arr)
{
    int top = 0;
    int bot = arr.GetLength(0) - 1;
    int left = 0;
    int right = arr.GetLength(1) - 1;
    int fillNum = 0;
    for (int i = top; i <= right; i++)
    {
        arr[top, i] = i + 1;
        fillNum = i + 1;
    }
    top++;
    for (int j = top; j <= bot; j++)
    {
        arr[j, right] = fillNum + j;
    }
    fillNum = arr[bot, right] + 1;
    for (int k = right - 1; k >= left; k--)
    {
        arr[bot, k] = fillNum;
        fillNum++;
    }
    fillNum = arr[bot, left];
    for (int p = bot - 1; p >= top; p--)
    {
        arr[p, left] = fillNum + 1;
        fillNum++;
    }
    fillNum = arr[top, left];
    for (int m = left + 1; m < right; m++)
    {
        arr[top, m] = fillNum + 1;
        fillNum++;
    }
    fillNum = arr[top, right - 1];
    for (int t = top + 1; t < bot; t++)
    {
        arr[t, right - 1] = fillNum + 1;
    }
    fillNum = arr[bot - 1, right - 1];

    for (int end = left + 1; end > left; end--)
    {
        arr[bot - 1, end] = fillNum + 1;

    }
}
 */


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


/* void SpiralFillArray(int[,] arr)
{
    int top = 0;
    int bot = arr.GetLength(0) - 1;
    int left = 0;
    int right = arr.GetLength(1) - 1;
    int fillNum = 0;
    for (int i = top; i <= right; i++)
    {
        arr[top, i] = i + 1;
        fillNum = i + 1;
    }
    top++;
    for (int j = top; j <= bot; j++)
    {
        arr[j, right] = fillNum + j;
    }
    fillNum = arr[bot, right] + 1;
    for (int k = right - 1; k >= left; k--)
    {
        arr[bot, k] = fillNum;
        fillNum++;
    }
    fillNum = arr[bot, left];
    for (int p = bot - 1; p >= top; p--)
    {
        arr[p, left] = fillNum + 1;
        fillNum++;
    }
    fillNum = arr[top, left];
    for (int m = left + 1; m < right; m++)
    {
        arr[top, m] = fillNum + 1;
        fillNum++;
    }
    fillNum = arr[top, right - 1];
    for (int t = top + 1; t < bot; t++)
    {
        arr[t, right - 1] = fillNum + 1;
    }
    fillNum = arr[bot - 1, right - 1];

    for (int end = left + 1; end > left; end--)
    {
        arr[bot - 1, end] = fillNum + 1;

    }
}
 */

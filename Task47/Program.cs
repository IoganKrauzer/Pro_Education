/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

Console.Clear();

int rows = Prompt("Введите количество строк для двумерного массива");
int columns = Prompt("Введите количество столбцов для двумерного массива");
int minValue = Prompt("Введите минимальное число для заполнения массива");
int maxValue = Prompt("Введите максимальное число для заполнения массива");

double[,] arrayDouble2d = CreatMatrixRndDouble(rows, columns, minValue, maxValue);
PrintMatrixArray(arrayDouble2d);





double[,] CreatMatrixRndDouble(int row, int col, int minV, int maxV)
{
    double[,] arr = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((rnd.NextDouble() * ((maxV) - minV) + minV), 1);
        }
    }
    return arr;
}


void PrintMatrixArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],10} ");
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

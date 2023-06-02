/* Задача 53: Задайте двумерный массив. Напишите программу,

которая поменяет местами первую и последнюю строку

массива.
 */
Console.Clear();

int rows = Prompt("Введите кол-во строк");
int columns = Prompt("Введите кол-во столбцов");
int minValue = Prompt("Введите минимальное число");
int maxValue = Prompt("Введите максимальное число");

int[,] array2d = CreatMatrixRndInt(rows, columns, minValue, maxValue);
PrintMatrixArray(array2d);
Console.WriteLine();
SwapRowsInArray(array2d);
PrintMatrixArray(array2d);




void SwapRowsInArray(int[,] arr)
{
    int i = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[i, j];
        arr[i, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = temp;
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


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

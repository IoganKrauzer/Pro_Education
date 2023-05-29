/* Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */


Console.Clear();


// int rows = Prompt("Введите кол-во строк");
// int columns = Prompt("Введите кол-во столбцов");
// int minValue = Prompt("Введите минимальное число");
// int maxValue = Prompt("Введите максимальное число");

int[,] array = CreatMatrixRndInt(3, 4, -100, 100);     //  array2d
PrintMatrixArray(array);

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

void PrintMatrixArray(int [,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j], 5} ");
    }
    Console.WriteLine();
}
}








// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }
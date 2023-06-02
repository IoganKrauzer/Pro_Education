/* Задача 55: Задайте двумерный массив. Напишите программу,

которая заменяет строки на столбцы. В случае, если это

невозможно, программа должна вывести сообщение для

пользователя. */

Console.Clear();

int rows = Prompt("Введите кол-во строк");
int columns = Prompt("Введите кол-во столбцов");
int minValue = Prompt("Введите минимальное число");
int maxValue = Prompt("Введите максимальное число");


if (IsSquareMatrix(rows, columns))
{
    int[,] array2d = CreatMatrixRndInt(rows, columns, minValue, maxValue);
    PrintMatrixArray(array2d);
    Console.WriteLine();
    // int[,] arrayNew2d = MatrixNewForSwapRowsWithColumns(array2d);
    ChangeRowsWithColumns(array2d);
    PrintMatrixArray(array2d);
    // PrintMatrixArray(arrayNew2d);

}
else Console.WriteLine("Error!!!");




// int[,] MatrixNewForSwapRowsWithColumns(int[,] arr)
// {
// int[,] array = new int[arr.GetLength(0),arr.GetLength(1) ];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[j,i] = arr[i,j];
//     }
// }
// return array;
// }


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


bool IsSquareMatrix(int row, int col)
{
    return row == col ? true : false;
}


void ChangeRowsWithColumns(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;

        }
    }
}
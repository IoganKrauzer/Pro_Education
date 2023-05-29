/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.

 */




int[,] array2d = CreatMatrixRndInt(5, 5);
PrintMatrixArray(array2d);
Console.WriteLine("\n");
RowForEvenIndex(array2d);
PrintMatrixArray(array2d);




void RowForEvenIndex(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) arr[i, j] = arr[i, j] * arr[i, j];
            else continue;
        }
    }
}



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




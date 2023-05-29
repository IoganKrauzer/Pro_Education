/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого элемента в массиве нет */


Console.Clear();
int[,] array2d = CreatMatrixRndInt(5, 7);

// PrintMatrixArray(array2d);


int[,] CreatMatrixRndInt(int row, int col)
{
    int[,] arr = new int[row, col];
    return arr;
}


// bool 





// void PrintMatrixArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {

//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j],5} ");
//         }
//         Console.WriteLine();
//     }
// }

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

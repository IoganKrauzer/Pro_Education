/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого элемента в массиве нет */


Console.Clear();

int rows = Prompt("Введите количество строк для двумерного массива");
int columns = Prompt("Введите количество столбцов для двумерного массива");

int[,] array2d = CreatMatrixRndInt(rows, columns, -10, 10);
PrintMatrixArray(array2d);

int getElemRowPos = Prompt("Введите номер строки для поиска элемента");
int getElemColPos = Prompt("Введите номер столбца для поиска элемента");




if (IsNaturalNumbers(getElemRowPos, getElemColPos))
{
    if (IsElemExistInMatrix(rows, columns, getElemRowPos, getElemColPos))
    {
        Console.WriteLine($"По номеру строки {getElemRowPos} и номеру столбца {getElemColPos}"
                         + $" значение элемента -> {FindElemInArray2d(array2d, getElemRowPos, getElemColPos)}");
    }
    else Console.WriteLine($"Такого элемента с номером строки {getElemRowPos} и столбца {getElemColPos}  не существует!");
}
else Console.WriteLine("Вы ввели отрицательное число!");




int FindElemInArray2d(int[,] arr, int getRow, int getCol)
{
    int elem = arr[getRow, getCol];
    return elem;
}


bool IsElemExistInMatrix(int row, int col, int getRow, int getCol)
{
    return getRow < row && getCol < col ? true : false;
}


bool IsNaturalNumbers(int row, int col)
{
    return row >= 0 && col >= 0 ? true : false;
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

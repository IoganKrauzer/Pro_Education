/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

int rows = Prompt("Введите кол-во строк первого массива");
int columns = Prompt("Введите кол-во столбцов первого массива");

int[,] array2d = new int[rows, columns];
FillArraySpiralByRecursion(array2d, 0, 0, array2d.GetLength(0) - 1, array2d.GetLength(1) - 1);
PrintMatrixArray(array2d);





 void FillArraySpiralByRecursion(int[,] arr, int rowIndex, int colIndex, int rowHighBoundry, int colHighBoundry, int fillNum = 1)
{
    for (int i = rowIndex; i <= colHighBoundry; i++)
    {
        arr[rowIndex, i] = fillNum;
        fillNum++;
    }

    for (int i = rowIndex + 1; i < rowHighBoundry; i++)
    {
        arr[i, colHighBoundry] = fillNum;
        fillNum++;
    }

    if (rowIndex + 1 <= rowHighBoundry)
    {
        int indeX = colHighBoundry ;
        for (int i = indeX; i >= colIndex; i--)
        {
            arr[rowHighBoundry, i] = fillNum;
            fillNum++;
        }
    }

    if (colIndex + 1 <= colHighBoundry)
    {
        int indeY = rowHighBoundry - 1;
        for (int i = indeY; i > rowIndex; i--)
        {
            arr[i, colIndex ] = fillNum;
            fillNum++;
        }
    }

    if (rowIndex < rowHighBoundry && colIndex < colHighBoundry)
    {
        FillArraySpiralByRecursion(arr, rowIndex + 1, colIndex + 1, rowHighBoundry - 1, colHighBoundry - 1, fillNum);
    }
}
 
    
void PrintMatrixArray(int[,] arr)
{
    Console.WriteLine();
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



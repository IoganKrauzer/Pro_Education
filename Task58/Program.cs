/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */

Console.Clear();

int rowsArray1 = Prompt("Введите кол-во строк первого массива");
int columnsArray1 = Prompt("Введите кол-во столбцов первого массива");
int rowsArray2 = Prompt("Введите кол-во строк второго массива");
int columnsArray2 = Prompt("Введите кол-во столбцов второго массива");

int[,] firstArray2d = CreatMatrixRndInt(rowsArray1, columnsArray1, 1, 6);
int[,] secondArray2d = CreatMatrixRndInt(rowsArray2, columnsArray2, 1, 6);
PrintMatrixArray(firstArray2d);
PrintMatrixArray(secondArray2d);


if (IsMatrixesMultiplied(firstArray2d, secondArray2d))
{
    int[,] multipliedArray = MethodToMulptiplieArrays(firstArray2d, secondArray2d);
    Console.WriteLine($"Произведение двух матриц:\n");
    PrintMatrixArray(multipliedArray);
}
else
{
    Console.WriteLine("   По правилу умножения матриц: кол-во столбцов первой матрицы должно быть равно кол-ву строк второй \n"
                   + $"   Количество столбцов матрицы 1 равен: {firstArray2d.GetLength(1)} \n"
                   + $"   Количество строк матрицы 2 равен: {secondArray2d.GetLength(0)} \n"
                   + $"   Следовательно матрицы нельзя переумножить \n");
}





int[,] MethodToMulptiplieArrays(int[,] first, int[,] second)
{
    int[,] multipliedArr = new int[first.GetLength(0), second.GetLength(1)];
    int mult = 1;
    int sum = 0;
    for (int i = 0; i < multipliedArr.GetLength(0); i++)
    {
        for (int j = 0; j < multipliedArr.GetLength(1); j++)
        {
            for (int k = 0; k < second.GetLength(0); k++)
            {
                mult *= first[i, k] * second[k, j];
                sum += mult;
                mult = 1;
            }
            multipliedArr[i, j] = sum;
            sum = 0;
        }
    }
    return multipliedArr;
}


bool IsMatrixesMultiplied(int[,] first, int[,] second)
{
    return first.GetLength(1) == second.GetLength(0) ? true : false;
}


int[,] CreatMatrixRndInt(int row, int col, int minV, int maxV)
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
    Console.WriteLine();
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
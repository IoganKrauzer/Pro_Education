/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();

int rows = Prompt("Введите кол-во строк массива");
int columns = Prompt("Введите кол-во столбцов массива");
int deep = Prompt("Введите глубину массива");

if (IsArray3dCenBeFilledWithOnlyTwoDigitNum(rows, columns, deep))
{
    int[,,] array3d = CreatAndFillArray3dWithTwoDigitNumbers(rows, columns, deep);
    PrintArray3d(array3d);
}

else
{
    Console.WriteLine($"При размерах: \n 1) {rows} \n 2) {columns} \n 3) {deep} \nЗаполнить массив только двухзначными числами невозможно,"
                    + $"так как общее кол-во элементов трехмерного массива >> {rows*columns*deep} << превышают общее кол-во двухзначных чисел >> 90 <<");
}





bool IsArray3dCenBeFilledWithOnlyTwoDigitNum(int row, int col, int dep)
{
    return row * col * dep <= 90 ? true : false;
}


int[,,] CreatAndFillArray3dWithTwoDigitNumbers(int row, int col, int dep)
{
    int sum = 9;
    int[,,] arr = new int[row, col, dep];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                sum = sum + 1;
                arr[i, j, k] = sum;
            }
        }
    }
    return arr;
}


void PrintArray3d(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k],3}({i},{j},{k}) ");
            }
            Console.WriteLine();
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




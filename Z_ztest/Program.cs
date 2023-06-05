// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] array2d = CreatMatrixRndInt(3, 4, 0, 2);
PrintMatrixArray(array2d);
SumOfRowsInArray2d(array2d);




void SumOfRowsInArray2d(int[,] arr)
{
    int[] sumOfRowsArr = new int[arr.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        sumOfRowsArr[i] = sum;
        sum = 0;
    }

        for (int i = 0; i < sumOfRowsArr.Length; i++)
    {

        Console.Write($"{sumOfRowsArr[i],5} ");
    }
    Console.WriteLine();

 int min = 0;
    for (int i = 0; i < sumOfRowsArr.Length; i++)
    {
     
        if (sumOfRowsArr [min]> sumOfRowsArr[i])  min = i;
    }
   Console.WriteLine(sumOfRowsArr[min]);
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


// void PrintArray(int[] ar)
// {
//     for (int i = 0; i < ar.Length; i++)
//     {

//         Console.Write($"{ar[i],5} ");
//     }
//     Console.WriteLine();
// }


















/* Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArrayRndInt(size, 100, 1000);
Console.WriteLine($"Массив состоит из {size} элементов, из них {EvenNumber(array)} четные числа");
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine($"] -> {EvenNumber(array)}");



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}


void PrintArray(int[] arr, string sep) //sep - параметр для разделения (запятая и прочие)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}


int EvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

 */
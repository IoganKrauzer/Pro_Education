// / Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




/* int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)  
{
    int[,] matrix = new int[rows, columns];                              
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)                
    {
        for (int j = 0; j < matrix.GetLength(1); j++)           
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)           
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");  
        }
        Console.WriteLine();
    }
}



double [] Average (int [,] matr)
{
    double[] arr = new double [matr.GetLength(1)];   // Создаем массив одномерный. Длинна = кол-ву столбцов двумерного.
    
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;                      // сумму задаем здесь, так как она должна обнуляться перед каждым циклом подсчета.
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];           // ищем сумму столбца
        }
        arr[j] = Math.Round(sum / matr.GetLength(0), 1);   //цикл подсчета суммы закончился и мы находим среднееарифм. И округляем до 1 знака. Метод Math.Round(num, 1);
    }
    return arr;   // возвращаем массив
}

void PrintArray(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}" + '.');
    }
  
}



int [,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);

double [] average = Average(array2d);


PrintArray(average, ";");
  Console.WriteLine();



 */





// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArrayRndInt(size, -10, 100);
Console.WriteLine($"всего {size} чисел, сумма элементов на нечётных позициях = {SumOddNumber(array)}");
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine($"] -> {SumOddNumber(array)}");

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

int SumOddNumber(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i = i + 1)
    {
     sum = sum + arr[i];
    }
    return sum;
}

























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
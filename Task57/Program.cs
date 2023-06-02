/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
 */

Console.Clear();

int[,] array2d = CreatMatrixRndInt();
PrintMatrixArray(array2d);
int[] array = SimpleArray(array2d);
Array.Sort(array);
PrintArray(array);
CountNumbersFromLowToHigh(array);



void CountNumbersFromLowToHigh(int[] ar)
{
    int currentValue = ar[0];
    int count = 1;
    for (int i = 1; i < ar.Length; i++)
    {

        if (ar[i] == currentValue) count++;
        else
        {
            Console.WriteLine($"{currentValue} в массиве используется: {count} раз");
            count = 1;
            currentValue = ar[i];
        }
    }
    Console.WriteLine($"{currentValue} в массиве используется: {count} раз");

}



int[] SimpleArray(int[,] arr)
{
    int[] ar = new int[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            ar[count] = arr[i, j];
            count++;
        }
    }
    return ar;
}


int[,] CreatMatrixRndInt(int row = 3, int col = 3, int minV = 0, int maxV = 10)
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


void PrintArray(int[] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {

        Console.Write($"{ar[i],5} ");

    }
    Console.WriteLine();
}
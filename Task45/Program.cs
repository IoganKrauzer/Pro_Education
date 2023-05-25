// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.Clear();

int lengthArr = Prompt("Введите длинну массива");


int[] array = CreateArray(lengthArr);
SeeArray(array, ",");
Console.WriteLine("\n");
int[] newarray = ArrayCopy(array);
SeeArray(newarray, ",");
Console.WriteLine();

int [] ArrayCopy (int []arr)
{
    int[] newarr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newarr[i] = arr[i];
    }
    return newarr;
}



int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 12);
    }
    return arr;
}

void SeeArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
}

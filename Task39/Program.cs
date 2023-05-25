// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



Console.Clear();

int lengthArray = Prompt("Введите длинну массива");
int minValue = Prompt("Введите минимальное число массива");
int maxValue = Prompt("Введите максимальное число массива");
int[] array = CreateArray(lengthArray, minValue, maxValue);
SeeArray(array);
Console.WriteLine("\n");
ReverseArray(array);
SeeArray(array);
Console.WriteLine("");


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] CreateArray(int size, int minV, int maxV)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minV, maxV + 1);
    }
    return arr;
}

void SeeArray(int[] arr, string sep = ",", string bracketF = "[ ", string bracketB = " ]")
{
    Console.Write($"{bracketF}");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write($"{bracketB}");
}

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length -1 - i] = temp;
    }
}






































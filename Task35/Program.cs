/* Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */


Console.Clear();

int siz = Prompt("Введите длинну массива");
int minValue = Prompt("Введите минимальное число для массива");
int maxValue = Prompt("Введите максимальное число для массива");
int[] array = CreateArray(siz, minValue, maxValue);
SeeArray(array,",");
int countNumbers = CountNumbers(array, 10, 99);
Console.Write("->  " + countNumbers + "\n");






int Prompt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
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

void SeeArray(int[] arr, string sep)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.Write($"{arr[arr.Length - 1]} ");
    Console.Write(" ]  ");
}

int CountNumbers (int[] arr, int minInt, int maxInt)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= minInt && arr[i] <= maxInt) count++;
    }
    return count;
}

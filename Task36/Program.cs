/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();


int lengthArray = Prompt("Введите длинну массива");
int minValue = Prompt("Введите минимальное число массива");
int maxValue = Prompt("Введите максимальное число массива");
if (minValue < maxValue)
{
    int[] array = CreateArray(lengthArray, minValue, maxValue);
    Console.Write("[");
    SeeArray(array, ",");
    Console.Write("] ");
    Console.Write($" -> {SumOddNumbers(array)} \n");
    Console.Write($"Сумма элементов на нечетных позициях равняется: {SumOddNumbers(array)} \n");
}

else
{
    Console.Write("Осторожно!!! Программа могла крашнуться!\n");
}


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

void SeeArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
}

int SumOddNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
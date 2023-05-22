/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

Console.Clear();

int siz = Prompt("Введите длинну массива");
int minValue = Prompt("Введите минимальное число для массива");
int maxValue = Prompt("Введите максимальное число для массива");
int[] array = CreateArray(siz, minValue, maxValue);
SeeArray(array,",");
InvertArray(array);
SeeArray(array,",");




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
    Console.WriteLine(" ]\n");
}

void InvertArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = arr[i] * -1;
}
}
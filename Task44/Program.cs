// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Clear();

int numbFib = Prompt("Введите число Фиб");


Console.Write($"Если число Фибоначчи = {numbFib} -> ");
SeeArray(FibbCreateAndFillArray(numbFib));




int[] FibbCreateAndFillArray(int size)
{
    int[] arr = new int[size];
    arr[1] = 1;

    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    return arr;
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void SeeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}










/* int[] Fibonacci(int num)
{
    int[] arr = new int[num];
    // arr[0] = 0;
    arr[1] = 1;

    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}
 */
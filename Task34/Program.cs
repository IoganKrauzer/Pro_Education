/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

 */



Console.Clear();
int lengthArray = Prompt("Введите длинну массива");

int[] array = CreateArray(lengthArray, 100, 999);
Console.Write("Количество четных чисел в массиве: ");
Console.Write("[");
SeeArray(array, ",");
Console.Write($"] -> {CountEvenNumbers(array)} \n");



int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] CreateArray(int size, int minInterv, int maxInterv)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minInterv, maxInterv + 1);
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

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}





// int IntervalCheck(int checkNumber, int minInterv, int maxInterv)
// {
//     while (checkNumber < minInterv || checkNumber > maxInterv)
//     {
//         if (checkNumber < 0)
//         {
//             Console.WriteLine("Число не является положительным");
//             checkNumber = Prompt("Введите другое число");
//         }
//         else
//         {
//             Console.WriteLine("Число не является трехзначным");
//             checkNumber = Prompt("Введите другое число");
//         }
//     }
//     return checkNumber;
// }



// Console.Clear();
// int lengthArray = Prompt("Введите длинну массива");
// int minValue = Prompt("Введите минимальное положительное трехзначное число");
// int minValueNew = IntervalCheck(minValue, 100, 999);
// int maxValue = Prompt("Введите максимальное положительное трехзначное число");
// int maxValueNew = IntervalCheck(maxValue, 100, 999);

// if (minValueNew < maxValueNew)
// {
//     int[] array = CreateArray(lengthArray, minValueNew, maxValueNew);
//     int countEvenNumbers = CountEvenNumbers(array);
//     Console.Write("Количество четных чисел в массиве: ");
//     Console.Write("[");
//     SeeArray(array, ",");
//     Console.Write("] -> " + countEvenNumbers + "\n");
// }
// else
// {
//     Console.Write("DANGER!!! Программа могла крашнуться!\n");
// }
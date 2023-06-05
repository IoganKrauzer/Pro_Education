/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();


int number = Prompt("Введите  натуральное число");

if (IsNumberNatural(number))
{
    Console.Write($"N = {number} -> ");
    PrintNaturalNumbersFromUpToDown(number);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Вы ввели не натруальное число!");
}




void PrintNaturalNumbersFromUpToDown(int num)
{
    if (num <= 0) return;
    Console.Write($"{num} ");
    PrintNaturalNumbersFromUpToDown(num - 1);
}


bool IsNumberNatural(int num)
{
    return num >= 1 ? true : false;
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


/* Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
 */

Console.Clear();


int number = Prompt("Введите  натуральное число");

PrintNaturalNumbers (number);



void PrintNaturalNumbers (int num)
{
    if (num  == 0) return;
    PrintNaturalNumbers(num - 1);
    Console.Write($"{num} ");
    
}




int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

number2 = ChechSec(number2);
int answer = MultiNumbers(number1, number2);
Console.WriteLine($"Результат возведения числа {number1} в степень {number2} равен {answer}");


int MultiNumbers(int num1, int num2)
{
    int result = 1;
    if (num2 == 0) return 1;
    if (num2 > 0)
    {
        for (int i = num2; i > 0; i--)
        {
            result = result * num1;
        }
    }
    return result;
}

int ChechSec(int num2)
{
    while (num2 < 0)
    {
        Console.WriteLine("Введите второе число");
        num2 = Convert.ToInt32(Console.ReadLine());
    }
    return num2;
}

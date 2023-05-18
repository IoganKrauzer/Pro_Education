// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sunAnswer = SumCount(number);
Console.WriteLine($"Сумма всех цифр в числе {number} равняется {sunAnswer}");


int SumCount (int num)
{
    int sum = 0;
    int remain = 0;
    while (num != 0)
    {
        remain = num % 10;
        sum = sum + remain;
        num = num / 10;
    }
    return sum;
}
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int answer = SecondNum(number);
Console.WriteLine("Второе число:  " + answer);

int SecondNum(int num)
{
    return (num / 10) % 10;
}
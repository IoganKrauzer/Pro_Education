// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// 12 мин

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное число в отрезке от 100 ... 999 " + number);


int answer = Digit(number);
Console.WriteLine(answer);

int Digit(int num)
{
    int firstNum = num / 100;
    int thirdNum = num % 10;
    int mathDecision = firstNum * 10 + thirdNum;
    return mathDecision;
}

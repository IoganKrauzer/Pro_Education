// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру");
int num = int.Parse(Console.ReadLine());

if (num < 1 || num > 7) Console.WriteLine("Введите другое число");
else
{
    bool answDay = DayOff(num);
    Console.WriteLine(answDay ? "Выходной день" : "Рабочий день");
}


bool DayOff(int number)
{
    return 6 <= number && number <= 7;
}
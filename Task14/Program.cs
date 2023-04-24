// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

bool answer = DivDigit(number);
Console.WriteLine(answer ? "Да" : "Нет");

bool DivDigit(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
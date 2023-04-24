// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.Clear();
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());


bool answer = SquarRes(num1, num2);
Console.WriteLine(answer ? "Да" : "Нет");



bool SquarRes(int n1, int n2)
{
    return n1 == n2 * n2 || n2 == n1 * n1;
}
// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = MathSum(number);
Console.WriteLine($"Cумма чисел от 1 до {number} = {result}");





int MathSum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
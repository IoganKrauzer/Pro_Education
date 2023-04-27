// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

Sqwrl(num);

void Sqwrl(int number)
{
    for (int i = 1; i<=num; i++)
{
    Console.WriteLine($"{i,3} {i *i,5}");
}
    // int i = 1;
    // while (i <= number)
    // {
    //     Console.WriteLine($" {i *i}");
    //     i++;
    // }
    
}
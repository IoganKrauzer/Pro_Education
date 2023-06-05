/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.Clear();

int number = Prompt("Введите  натуральное число");
Console.WriteLine(RecursionSum(number));

int RecursionSum(int num)
{
    if (num == 0) return 0;
    return num % 10 + RecursionSum(num / 10);
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


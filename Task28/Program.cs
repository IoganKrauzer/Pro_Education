// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int answer = ConjNumb(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {answer}");


int ConjNumb(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}


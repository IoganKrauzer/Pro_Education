//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
//Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49



Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int square = number * number;
Console.Write("Ответ: ");
Console.WriteLine(square);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Clear();
Console.WriteLine("Введите число");
Console.Write("Число:  ");
int number = Convert.ToInt32(Console.ReadLine());

CubeNum(number);


void CubeNum(int num)
{
    if (num > 0)
    {
        for (double i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i,3}   " + "|   " + $"{Math.Pow(i, 3),5}");
        }
    }
    else
        Console.WriteLine("Вы ввели некорректное число!");
}


// на всякий случай решение через тип int : 
// void CubeNum(int num)
// {
//     if (num > 0)
//     {
//         for (int i = 1; i <= num; i++)
//         {
//             Console.WriteLine($"{i,3}   " + "|   " + $"{i * i * i,5}");
//         }
//     }
//     else
//         Console.WriteLine("Вы ввели некорректное число!");
// }
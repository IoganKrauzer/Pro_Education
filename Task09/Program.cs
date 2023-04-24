// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();
int n = new Random().Next(10, 100);
Console.WriteLine(n);
// Console.WriteLine("Случайное число из отрезка 10 ... 99 : " + n);
// int a = n / 10;
// int b = n % 10;

// Console.WriteLine(a);
// Console.WriteLine(b);

// if (a > b)
// {
//     Console.WriteLine(a);
// }
// else
// {
//     Console.WriteLine(b);
// }

// int max = a > b ? a : b; 
// Console.WriteLine(max);

int max = MaxDigit(n);
Console.WriteLine(max);

int MaxDigit(int num)
{
    int a = num / 10;
    int b = num % 10;
    int max = a > b ? a : b; 
    return max;
}

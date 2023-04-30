// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Clear();
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());


if (num >= 0)
{
    int revNum = ReversNumb(num);
    PalinAnswer(num, revNum);
}
else
{
    Console.WriteLine($"Число: \"{num}\" является отрицательным числом.");
    Console.WriteLine("Отрицательные числа не могут быть палиндромами!");
}


int ReversNumb(int n)
{
    int reverse = 0;

    while (n != 0)
    {
        int remain = n % 10;
        reverse = reverse * 10 + remain;
        n = n / 10;
        return reverse;
    }
    return 0;
}


void PalinAnswer(int nu, int revNu)
{
    string answer = nu == revNu ? $"Число: \" {nu} \" является палиндромом!" : $"Число: \" {nu} \" не является палиндромом!";
    Console.WriteLine(answer);
}
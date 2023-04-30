// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Clear();
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());


int revNum = ReversNumb(num);
string answer = (num == revNum && num != 0) ? $"Число: \" {num} \" является палиндромом!" : $"Число: \" {num} \" не является палиндромом!";
Console.WriteLine(answer);


int ReversNumb(int n)
{
    int reverse = 0;
    if (n <= -10 || n >= 10)
    {
        while (n != 0)
        {
            int remain = n % 10;
            reverse = reverse * 10 + remain;
            n = n / 10;
        }
        return (reverse);
    }
    return 0;
}



// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Clear();
Console.WriteLine("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine());


num = IntervCheck2(num);
bool palindr = PalindrFunc(num);
string answer = palindr == true ? $"Число: {num} является палиндромом!" : $"Число: {num} не является палиндромом!";
Console.WriteLine(answer);



bool PalindrFunc(int n)
{
    int firstN = n / 10000;
    int fifthN = n % 10;
    int secN = (n / 1000) % 10;
    int fourthN = (n % 100) / 10;
    return (firstN == fifthN && secN == fourthN) ? true : false;
}



int IntervCheck2(int nu)
{
    while ((nu < -99999) || ((nu > -10000) &&(nu < 10000)) || (nu > 99999))
    {
        Console.WriteLine ("Число не является пятизначным!");
        Console.WriteLine("Введите новое число ");
        nu = int.Parse(Console.ReadLine());
    }
    return nu;
}

// Boolean ПРОВЕРКА:

// bool check = IntervCheck(num);

// if (check == true)
// {
//     bool palindr = ReversNumb(num);
//     string answer = palindr == true ? $"Число: {num} является палиндромом!" : $"Число: {num} не является палиндромом!";
//     Console.WriteLine(answer);
// }

// bool IntervCheck(int nu)
// {
//     return (nu > -99999 && nu < -10000) || (nu > 10000 && nu < 99999);
// }
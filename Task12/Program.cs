// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Clear();
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());

int answer = RemDiv(num1, num2);
string result = answer != 0 ? $"Число {num1} не кратно {num2}. Остаток = {answer}" : "кратно";
Console.WriteLine(result);

// if (answer == 0)
// {
//     Console.WriteLine($" Число {num1} кратно {num2}");
//     Console.WriteLine($"Остаток: =  {answer}");
// }
// else
// {
//     Console.WriteLine($" Число {num1} не кратно {num2}");
//     Console.WriteLine($"Остаток: =  {answer}");
// }


int RemDiv(int nu1, int nu2)
{

    return nu1 % nu2;
}

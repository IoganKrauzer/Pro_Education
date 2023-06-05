/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();

int number1 = Prompt("Введите первое число ");
int number2 = Prompt("Введите второе число ");

if (IsNumbersAreNatural(number1, number2))
{
    Console.WriteLine($" Первое число = {number1}, Второе число = {number2} -> A({number1},{number2}) = {MethToFindAckermannValuesByRecurs(number1, number2)}");
}
else
{
    Console.WriteLine("Вы ввели отрицательное число или числа!");
}





int MethToFindAckermannValuesByRecurs(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0) return MethToFindAckermannValuesByRecurs(num1 - 1, 1);
    return MethToFindAckermannValuesByRecurs(num1 - 1, MethToFindAckermannValuesByRecurs(num1, num2 - 1));
}


bool IsNumbersAreNatural(int num1, int num2)
{
    return num1 >= 0 && num2 >= 0 ? true : false;
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}








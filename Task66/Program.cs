/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

int number1 = Prompt("Введите первое натуральное число ");
int number2 = Prompt("Введите второе натуральное число ");

if (IsNumbersNatural(number1, number2))
{
    string sumBetweenNum1AndNum2 = number1 >= number2 ? $"Cумма натуральных чисел в промежутке от {number2} до {number1} равна: {SumBetweenNum1AndNum2(number1, number2)} "
    : $"Cумма натуральных чисел в промежутке от {number1} до {number2} равна: {SumBetweenNum1AndNum2(number1, number2)} ";
    Console.WriteLine(sumBetweenNum1AndNum2);
}
else
{
    Console.WriteLine("Error!!! Введенные вами числа должны быть натуральными!");
}




int SumBetweenNum1AndNum2(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1 + SumBetweenNum1AndNum2(num1 - 1, num2);
    }
    else if (num1 < num2)
    {
        return num1 + SumBetweenNum1AndNum2(num1 + 1, num2);
    }
    else return num1;
}


bool IsNumbersNatural(int num1, int num2)
{
    return num1 > 0 && num2 > 0 ? true : false;
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.Clear();
int numberA = Prompt("Введите  натуральное число A");
int numberB = Prompt("Введите  натуральное число B");
Console.WriteLine(MultNumberByItself(numberA, numberB));


int MultNumberByItself(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * MultNumberByItself(numA, numB - 1);
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}




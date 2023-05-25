// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.Clear();

int numberA = Prompt("Введите первое число");
int numberB = Prompt("Введите второе число");
int numberC = Prompt("Введите третье число");

bool answer = TriangleCheck(numberA, numberB, numberC);
string finAnser = answer ==true ? "Является треугольником" : "Не является треугольником";
Console.WriteLine(finAnser);




bool TriangleCheck(int a, int b, int c)
{
    return a < b+ c ? b < a + c ? c < a + b ? true : false : false : false;
}



int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
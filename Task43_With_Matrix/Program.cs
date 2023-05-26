// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями / значения b1, k1, b2 и k2 задаются пользователем. -> (-0,5; -0,5)

//y = k1 * x + b1,     
//y = k2 * x + b2;                      

// k1 = 5,    b1 = 2, 
// k2 = 9,    b2 = 4,             

Console.Clear();

int numberK1 = Prompt("Введите первое число K1");
int numberB1 = Prompt("Введите второе число B1");
int numberK2 = Prompt("Введите третье число K2");
int numberB2 = Prompt("Введите четвертое число B2");
double[] array = CrossPointBetweenTwoStrLines(numberK1, numberB1, numberK2, numberB2);
Console.WriteLine($"Точка пересечения между двумя прямыми : ({array[0]}; {array[1]})");





double[] CrossPointBetweenTwoStrLines(int numK1, int numB1, int numK2, int numB2)
{
    double firstStep = numB2 - numB1;
    double secondStep = numK1 - numK2;
    double x = Math.Round(firstStep / secondStep, 1);
    double y = Math.Round(numK2 * x + numB2, 1);
    return new double[2] { x, y };
}




int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

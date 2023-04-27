// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Введите для точки А х:");
int numAx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки А y:");
int numAy = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки B х:");
int numBx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки B y:");
int numBy = int.Parse(Console.ReadLine());

double answer = Pifa(numAx, numAy, numBx, numBy);
double finAnswer = Math.Round(answer, 2, MidpointRounding.ToZero);
Console.WriteLine(finAnswer);

double Pifa(int nAx, int nAy, int nBx, int nBy)
{
    int cat1 = nAx - nBx;
    int cat2 = nAy - nBy;
    double hypo = Math.Sqrt((cat1 * cat1) + (cat2 * cat2));
    return hypo;
}
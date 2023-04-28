// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите для точки А х:");
int xPointA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки А y:");
int yPointA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки А z:");
int zPointA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите для точки B х:");
int xPointB = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите для точки B y:");
int yPointB = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите для точки B z:");
int zPointB = int.Parse(Console.ReadLine()); 

double twoPointsDistance = TwoPointsDistance(xPointA, yPointA, zPointA, xPointB, yPointB, zPointB);
double finAnswer = Math.Round(twoPointsDistance, 2, MidpointRounding.ToZero);
Console.WriteLine("Расстояние между точками А и В составляет -> " + finAnswer);


double TwoPointsDistance(int xPoiA, int yPoiA, int zPoiA, int xPoiB, int yPoiB, int zPoiB)
{
    int side1 = xPoiA - xPoiB;
    int side2 = yPoiA - yPoiB;
    int side3 = zPoiA - zPoiB;
    double hypo = Math.Sqrt(side1 * side1 + side2 * side2 + side3 * side3);
    return hypo;
}
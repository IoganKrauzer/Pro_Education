/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

Console.Clear();
int siz = Prompt("Введите длинну массива");
int minValue = Prompt("Введите минимальное число для массива");
int maxValue = Prompt("Введите максимальное число для массива");
int guesNumber = Prompt("Введите  число для поиска");
// Console.WriteLine();
int[] array = CreateArray(siz, minValue, maxValue);
SeeArray(array,",");
Console.WriteLine();
bool answer = SearchNumber(array, guesNumber);
string finAnswer = answer == true ? "Да!" : "Нет!";
Console.Write($" {guesNumber};  массив  ");
SeeArray(array,",");
Console.Write(" -> " + finAnswer + "\n");






int Prompt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[] CreateArray(int size, int minV, int maxV)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minV, maxV + 1);
    }
    return arr;
}

void SeeArray(int[] arr, string sep)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.Write($"{arr[arr.Length - 1]} ");
    Console.Write("]");
}

bool SearchNumber (int[] arr, int gues)                                  
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == gues) result = true;
       
    }
return result;
}
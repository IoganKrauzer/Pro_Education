// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Clear();

int countNumbers = Prompt("Сколько чисел вы хотите вывести?");
int[] array = CreateArrayForCount(countNumbers);


Console.Write("В последовательности ");
SeeArray(array, "", "" );
Console.WriteLine($" чисел больше 0 ->  {CountNumbersHigherNull(array)}");
SeeArray(array, "", "" );
Console.WriteLine($" -> {CountNumbersHigherNull(array)}");





int CountNumbersHigherNull(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}



int[] CreateArrayForCount(int count)
{
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Prompt($"Введите число № {i + 1} !");
    }
    return arr;

}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


void SeeArray(int[] arr,  string bracketF = "[ ", string bracketB = " ]", string sep = ",")
{
    Console.Write($"{bracketF}");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write($"{bracketB}");
}

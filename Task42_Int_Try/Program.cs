// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10


Console.Clear();

int number = Prompt("Введите  число для перевода в двоичную систему исчисления");

int countNumberForDecToBin = CountNumberForDecToBin(number);
int[] array = CreateArrayForDecToBin(countNumberForDecToBin);
FillArrayDecToBin(array, number);
Console.WriteLine();
Console.Write($" Десятичное число {number} в двоичной системе: {number} -> ");
SeeArray(array);



void FillArrayDecToBin(int[] arr, int num)
{
    int remainder = 0;
    int i = countNumberForDecToBin - 1;
   while (num != 0)
   {
        remainder = num % 2;
        num = num / 2;
        arr[i] = remainder;
        i--;
   }
}


int CountNumberForDecToBin(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 2;
        count++;
    }
    return count;
}

int[] CreateArrayForDecToBin(int countNum)
{
    int[] arr = new int[countNum];
    return arr;
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void SeeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "");
    }
    Console.WriteLine("\n");
}
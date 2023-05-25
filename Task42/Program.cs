// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

Console.Clear();

int number = Prompt("Введите  число для преобразование в двоичное");


Console.WriteLine($"Десятичное число {number} преобразуется в двоичное {DecToBin (number)}");
Console.WriteLine($"{number} -> {DecToBin (number)}");




string DecToBin (int num)
{
    string result = String.Empty;
    while (num > 0)
 {
   result = num % 2 + result;
   num = num /2;
 }
 return result;
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}




// Console.WriteLine("Введите целое число ");
// int number = Convert.ToInt32(Console.ReadLine());

// string result = DecToBin(number);
// Console.WriteLine(result);

// string DecToBin(int num)
// {
//     string res = string.Empty;
//     while (num > 0)
//     {
//         res = num % 2 + res;
//         num = num / 2;
//     }
//     return res;
// }

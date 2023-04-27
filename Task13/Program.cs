// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


number = -number;

Console.WriteLine(number);

if (number < 100) Console.WriteLine("У числа нет третьей цифры");

else
{
    int answer = RemDig(number);
    Console.WriteLine("Третье число " + answer);
}



int RemDig(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
    
}




// number = -number

// number *= -1
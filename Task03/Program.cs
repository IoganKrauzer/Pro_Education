//  Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер...");
// int number = int.Parse(Console.ReadLine());

// if (number == 1) Console.WriteLine("Понедельник!");
// if (number == 2) Console.WriteLine("Вторник!");
// if (number == 3) Console.WriteLine("Среда!");
// if (number == 4) Console.WriteLine("Четверг!");
// if (number == 5) Console.WriteLine("Пятница!");
// if (number == 6) Console.WriteLine("Суббота!");
// if (number == 7) Console.WriteLine("Воскресенье!");
// if (number < 1) Console.WriteLine("Неверный номер!");
// if (number > 7) Console.WriteLine("Неверный номер!");
     
string n = Console.ReadLine();

switch (n)
{
    
    case "1":
    Console.WriteLine("Понедельник!");
    break;

    case "2":
    Console.WriteLine("Вторник!");
    break;

    case "3":
    Console.WriteLine("Среда!");
    break;

    case "4":
    Console.WriteLine("Четверг!");
    break;

    case "5":
    Console.WriteLine("Пятница!");
    break;

    case "6":
    Console.WriteLine("Суббота!");
    break;

    case "7":
    Console.WriteLine("Воскресенье!");
    break;

    default:
    Console.WriteLine("Введите корректное значение дня недели");
    break;
}
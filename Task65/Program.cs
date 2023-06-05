/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

Console.Clear();


int numberM = Prompt("Введите  натуральное число M");
int numberN = Prompt("Введите  натуральное число N");
PrinNatNumbersInRange(numberM, numberN);
Console.WriteLine();




void PrinNatNumbersInRange (int numM, int  numN)
{
    if (numM < numN)
    {
        //   PrinNatNumbersInRange (numM + 1 , numN );
         Console.Write(numM + " ");
        PrinNatNumbersInRange (numM + 1 , numN );
    }
    
   else if (numM > numN)
    {
        Console.Write(numM + " ");
        PrinNatNumbersInRange (numM - 1, numN);
    }
else   Console.Write(numM);
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


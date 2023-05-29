System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

int row = Prompt("Введите кол-во строк");
int col = Prompt("Введите кол-во столбцов");
int[,] array = CreateArray(row, col);

// SeeArray(array, ",");

void SeeArray(int[] arr, string sep = ",", string bracketF = "[ ", string bracketB = " ]")
{
    Console.Write($"{bracketF}");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}{sep} ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write($"{bracketB}");
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreateArray(int r, int c)
{
    int[,] arr = new int[r, c];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           arr[i,j] = rnd.Next(1, 11);
        }
    }
    return arr;
}

// void SeeArray(int[,] arr, string sep)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//          for (int j = 0; j < arr.GetLength(1); j++)
//         {
//           Console.Write($"{arr[i, j]}{sep} ");
//         }
//         Console.WriteLine();
//     }
   
// }


// int[] CreateArrayForCount(int count)
// {
//     int[] arr = new int[count];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = Prompt($"Введите число № {i + 1} !");
//     }
//     return arr;

// }


// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }


// void SeeArray(int[] arr,  string bracketF = "[ ", string bracketB = " ]", string sep = ",")
// {
//     Console.Write($"{bracketF}");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]}{sep} ");
//     }
//     Console.Write($"{arr[arr.Length - 1]}");
//     Console.Write($"{bracketB}");
// }
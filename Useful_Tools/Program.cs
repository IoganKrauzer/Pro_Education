System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

int row = Prompt("Введите кол-во строк");
int col = Prompt("Введите кол-во столбцов");
int[,] array = CreateArray(row, col);

SeeArray(array, ",");

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

void SeeArray(int[,] arr, string sep)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
         for (int j = 0; j < arr.GetLength(1); j++)
        {
          Console.Write($"{arr[i, j]}{sep} ");
        }
        Console.WriteLine();
    }
   
}
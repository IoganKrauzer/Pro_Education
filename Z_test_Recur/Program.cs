// Console.Clear();

// int[] array = CreateArray(3);
// PrintArray (array);
// Console.WriteLine();
// Console.WriteLine(RecutsionSum(array));



// int RecutsionSum(int[]arr, int index = 0)
// {
//     int sum = 0;

//    if (index >= arr.Length) return 0;
//    else 
//    {
//     sum += RecutsionSum(arr, index + 1);
//    }
//    return arr[index] + sum;

// }




// int[] CreateArray (int size, int num1 = 1, int num2 = 9)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(num1, num2 + 1);
//     }
//     return arr;
// }

// void PrintArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] +" ");
//     }
//     Console.WriteLine();
// }



System.Console.WriteLine(10);
int rows = Prompt("Введите кол-во строк первого массива");
int columns = Prompt("Введите кол-во столбцов первого массива");

int[,] array2d = new int[rows, columns];
FillArraySpiralByRecursion(array2d, 0, 0, array2d.GetLength(0) - 1, array2d.GetLength(1) - 1);
PrintMatrixArray(array2d);




void FillArraySpiralByRecursion(int[,] arr, int rowIndex, int colIndex, int rowHighBoundry, int colHighBoundry, int fillNum = 1)
{
    for (int i = rowIndex; i <= colHighBoundry; i++)
    {
        arr[rowIndex, i] = fillNum;
        fillNum++;
    }

    for (int i = rowIndex + 1; i <= rowHighBoundry; i++)
    {
        arr[i, colHighBoundry] = fillNum;
        fillNum++;
    }

    if (rowIndex + 1 <= rowHighBoundry)
    {
        int indeX = colHighBoundry - 1;
        for (int i = indeX; i >= colIndex; i--)
        {
            arr[rowHighBoundry, i] = fillNum;
            fillNum++;
        }
    }

    if (colIndex + 1 < colHighBoundry)
    {
        int indeY = rowHighBoundry - 1;
        for (int i = indeY; i > rowIndex; i--)
        {
            arr[i, colIndex] = fillNum;
            fillNum++;
        }
    }
    
    if (rowIndex <= rowHighBoundry && colIndex <= colHighBoundry)
    {
        FillArraySpiralByRecursion(arr, rowIndex + 1, colIndex + 1, rowHighBoundry - 1, colHighBoundry - 1, fillNum);
    }

}

void PrintMatrixArray(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
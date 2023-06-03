Console.Clear();

int[,] array2d = new int[3, 4]
{
{ 1, 2, 4, 2 },
{ 2, 4, 1, 5 },
{ 9, 8, 7, 11}
};
//  CreatMatrixRndInt(4, 4, 10, 30);
PrintMatrixArray(array2d);
CheckForEqualNumers(array2d);
PrintMatrixArray(array2d);



void CheckForEqualNumers(int[,] arr, int minV = 10, int maxV = 30)
{
    Random rnd = new Random();



    int pecker = 0;


    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int check = j + 1;
            while (check < arr.GetLength(1))
            {
                if (arr[i, j] == arr[i, check])
                {
                arr[i, j] = rnd.Next(minV, maxV);
                }
                check ++;
            }

        }
        pecker++;
    }



}


// int Recursion (int[,] arr, int r = 0, int c = 0)
// {

//     if (c >= arr.GetLength(1)) return  Recursion (arr, r + 1, c );
//     // Recursion (arr,r  , c + 1);
//     if (r >= arr.GetLength(0)) return Recursion (arr, r + 1, c );
// }


//     checker2 = j + 1;

//     if (arr[i, j] == arr[checker1, checker2])
//         // {
//         //    while (arr[checker1, checker2] == arr[i, j]) 
//         //    {
//         arr[i, j] = rnd.Next(minV, maxV);
//     //    } 


//     // }
// }







// int[,] CreatMatrixRndInt(int row, int col, int minV, int maxV)
// {
//     int[,] arr = new int[row, col];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = rnd.Next(minV, maxV + 1);
//         }
//     }
//     return arr;
// }


void PrintMatrixArray(int[,] arr)
{
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



/* void UsingSortByChoiceInMatrixArray(int[,] arr)
{

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int k = 0; k < array2d.GetLength(1); k++)
        {


            int max = k;
            for (int j = k+ 1; j < array2d.GetLength(1); j++)
            {
                if (array2d[i, max] < array2d[i, j]) max = j;
            }
            if (array2d[i, k] < array2d[i, max])
            {
                int temp = array2d[i, k];
                array2d[i, k] = array2d[i, max];
                array2d[i, max] = temp;
            }
        }
    }
}
 */


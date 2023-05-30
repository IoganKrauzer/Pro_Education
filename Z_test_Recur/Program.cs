Console.Clear();

int[] array = CreateArray(3);
PrintArray (array);
Console.WriteLine();
Console.WriteLine(RecutsionSum(array));



int RecutsionSum(int[]arr, int index = 0)
{
    int sum = 0;

   if (index >= arr.Length) return 0;
   else 
   {
    sum += RecutsionSum(arr, index + 1);
   }
   return arr[index] + sum;

}




int[] CreateArray (int size, int num1 = 1, int num2 = 9)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(num1, num2 + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] +" ");
    }
    Console.WriteLine();
}
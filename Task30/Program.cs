// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/* Console.Clear();

int[] array = new int[8];

FillArray(array);
Console.Write("[ ");
SeeArray(array);
Console.Write("]");
Console.WriteLine("\n");



void FillArray(int[] arr)
{
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}

void SeeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else  Console.Write(array[i] + " ");
    }
}
 */

//int[] arr = new int[8];

        //    FillArray(arr);
            int[] newArr = CreateArray(12);
            Console.Write("[");
            PrintArray(newArr);
            Console.Write("]");

            void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if(i < array.Length - 1) Console.Write($"{array[i]}, ");
                    else Console.Write($"{array[i]}");
                }

            }

            // void FillArray(int[] array)
            // {
            //     var rnd = new Random();
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         array[i] = rnd.Next(0, 2);
            //     }
            // }
            int[] CreateArray(int size)
            {
                int[] array = new int[size];
                var rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(0, 2);
                }
                return array;
            }
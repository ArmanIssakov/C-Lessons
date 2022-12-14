// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       if(i < array.Length -1) Console.Write($"{array[i]}," );
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}
int [] result = FillArray(8, 0 , 100);
PrintArray(result);
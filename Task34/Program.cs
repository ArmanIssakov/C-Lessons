// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");

}
void CheckEven (int [] array)
{
    int counter = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if(array[i] % 2 == 0) counter++;
    }
    Console.WriteLine($"Четных чисел в массиве {counter}");
}
int [] arr = CreateArrayRndInt(9, 100, 999);
PrintArray(arr);
Console.WriteLine();
CheckEven(arr);
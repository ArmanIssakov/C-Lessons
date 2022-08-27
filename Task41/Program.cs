// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите количество чисел для проверки:");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {

        Console.Write("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;

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
    Console.WriteLine("]");

}
void CounterPosDigits(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > 0) counter++;
    }
    Console.WriteLine($"Количество чисел больше нуля {counter}");
}
int[] res = CreateArray(arrayLength);
PrintArray(res);
CounterPosDigits(res);

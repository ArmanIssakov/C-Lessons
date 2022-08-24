// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементами массива.
double [] CreateArrayRndDouble (int size)
{
    double [] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble();
        array[i] = array[i] * 10;
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}
void PrintArray (double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
void MaxMinusMin (double[] array)
{
    double maxDesign = array[0];
    double minDesign = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxDesign) maxDesign = array[i];
        if(array[i] < minDesign) minDesign = array[i];
    }
    double result = 0;
    result = maxDesign - minDesign;
    Console.WriteLine(result);
}
double [] arr = CreateArrayRndDouble(4);
PrintArray(arr);
Console.WriteLine();
MaxMinusMin(arr);

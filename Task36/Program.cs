﻿// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
int [] CreateArrayRndInt (int size, int min, int max)
{
    int [] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max +1);
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length -1]);
    Console.Write("]");
}

void SumEvenIndex (int [] array)
{
    int sumEvenIndexDigit = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sumEvenIndexDigit += array[i];
    }
    Console.WriteLine($"Сумма чисел с четным индексом {sumEvenIndexDigit}");
}
int [] arr = CreateArrayRndInt(4, 1, 10);
PrintArray(arr);
Console.WriteLine();
SumEvenIndex(arr);
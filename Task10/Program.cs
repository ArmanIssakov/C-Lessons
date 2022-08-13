﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите положительное трехзначное число, для вывода второй цифры этого числа:");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 100;
if (number < 1000 && number > 99)
{
    result = number % 100;
    result = result / 10;
    Console.WriteLine($"Вторая цифра числа {number} это {result}");
}
else
{
    Console.WriteLine("Что то пошло не так, введите положительное трехзначное число.");
}


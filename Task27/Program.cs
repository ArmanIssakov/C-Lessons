// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int boof = 0;
int inputNumber = number;
for (; number >= 1; number = number / 10)
{
    boof = number % 10;
    result = result + boof;
}
Console.WriteLine($"Сумма цифр в числе {inputNumber} равно {result}");
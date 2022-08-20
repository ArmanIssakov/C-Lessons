// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;
for ( ; number >= 10; number = number / 10)
{
    counter++;
}
Console.WriteLine($"В числе {number} количество цифр равно {counter}");
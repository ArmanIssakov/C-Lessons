// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Write("Введите число, для вывода третьей цифры этого числа:");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (number > 999)
{
    number = number / 10;
}

if (number < 100)
{
    Console.Write("Введенное вами число является двухзначным или отрицательным");
}
else
{
    result = number % 100;
    result = result % 10;
    Console.Write($"{result}");
}
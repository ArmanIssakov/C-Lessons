// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите положительное число от 1 до 7 для определения, является ли этот день выходным:");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 7) Console.WriteLine($"{number} -> да");
else if (number == 6) Console.WriteLine($"{number} -> да");
else if (number == 5) Console.WriteLine($"{number} -> нет");
else if (number == 4) Console.WriteLine($"{number} -> нет");
else if (number == 3) Console.WriteLine($"{number} -> нет");
else if (number == 2) Console.WriteLine($"{number} -> нет");
else if (number == 1) Console.WriteLine($"{number} -> нет");
else Console.WriteLine("Введенное вами число не в диапозоне от 1 до 7");

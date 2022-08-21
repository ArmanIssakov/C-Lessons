// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Write("Введите число A:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int numB = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 1;
while(i <= numB)
{
    result = result * numA;
    i++;
}
Console.WriteLine($" Число А ({numA}) в степени числа В ({numB}) = {result}");
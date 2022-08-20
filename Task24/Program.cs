// Напишите программу, которая принимает на вход число (А)
//  и выдает сумму чисел от 1 до А

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= num; i++)
{
    sum += i;
}
Console.WriteLine($"Сумма чисел от 1 до {num} равно {sum}");
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите целое положительное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int m, int n)

{
    if (n == m) return m;

    return n + SumNumber(m, n - 1);// если ввести аргумент n = 8, m = 4 тогда на этой строке происходит следущее 8+7+6+5+4.

}
int res = SumNumber(numberM, numberN);
Console.WriteLine(res);
// Теперь я знаю, что значит мозг завис :))
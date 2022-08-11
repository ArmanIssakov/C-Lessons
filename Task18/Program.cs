Console.WriteLine("Введите номер четверти:");
int x = Convert.ToInt32(Console.ReadLine());
string QuarterNum(int numX)
{
    if (numX == 1) return "Диапозон х > 0 и y > 0";
    if (numX == 2) return "Диапозон х < 0 и y > 0";
    if (numX == 3) return "Диапозон х < 0 и y < 0";
    if (numX == 4) return "Диапозон х > 0 и y < 0";
    return "Введены некорректные координаты";
}
string result = QuarterNum(x);
Console.WriteLine($"{result}");



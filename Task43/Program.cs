// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
Console.Write("Введите значение b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2:");
double k2 = Convert.ToInt32(Console.ReadLine());
double [] FindPoint (double bb1, double kk1, double bb2, double kk2)
// // Для вычисления координат точки пересечения прямых, решим
// // систему уранений:
// // Вычтем из первого уравнения второе:
// // y - y = kk1 * x + bb1 - (kk2 * x + bb2) 
// // 0 = kk1x + bb1 - kk2x - bb2
// // kk2x - kk1x = bb1 - bb2
// // x(kk2-kk1)=bb1-bb2
// // x=(bb1-bb2)/(kk2-kk1)
{
    double y = 0;
    double x = 0;
    x = (bb1-bb2)/(kk2-kk1);
    y = kk2 * x + bb2;
    double[] array = {x,y};
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");

}
double [] res = FindPoint(b1,k1,b2,k2);
PrintArray(res);
// Console.WriteLine(x);
// Console.WriteLine(y);


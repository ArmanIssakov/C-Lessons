// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.Write("Введите координату x точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату у точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
double line = Math.Sqrt(Math.Pow((xB - xA), 2)+Math.Pow((yB - yA), 2));
// double line = Math.Sqrt((xB - xA)*(xB - xA)+(yB - yA)*(yB - yA));
Console.WriteLine($"Расстояние между точками равно {line}");

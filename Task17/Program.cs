// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки:");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string WhereI(int numX, int numY)
{
 if(numX > 0 && numY > 0) return "Мы находимся в первой четверти";

 if (numX < 0 && numY > 0) return   "Мы находимся во второй четверти";

 if (numX < 0 && numY < 0) return  "Мы находимся во третьей четверти";

 if (numX > 0 && numY < 0) return "Мы находимся во четвертой четверти";
 
 return "Введены некорректные координаты";
}



string result = WhereI(x,y);
Console.WriteLine($"{result}");

// string Quarter (int xc, int yc)
// {

// }



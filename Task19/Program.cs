// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Write("Введите пятизначное число для определения палиндромности: ");
int number = Convert.ToInt32(Console.ReadLine());
// string numLength = Convert.ToString(number);
// int numLengthInt =Convert.ToInt32(numLength);
// int digit1 = 10;
// int digit2 = 1;
// int count = 1;
// int digitBegin = 1;
// int digitEnd = 1;
// while(count <= numLengthInt)
// {
//     digit2 = digit2 * 10;
//     count++;
// }
// int count1 = 1;
// while(count1 < numLengthInt)
// {
//     digitBegin = number / digit2;
//     digitEnd = number % digit1;
// }
// Console.Write($"{digitBegin} | {digitEnd}");
int digit1 = number / 10000;
int digit2 = (number / 1000) % 10;
int digit4 = (number % 100) / 10;
int digit5 = (((number % 10000) % 1000) % 100) % 10;
if(digit1 == digit5 && digit2 == digit4) Console.WriteLine($"{number} - палиндром");
else Console.WriteLine($"{number} - не палиндром");
// Console.WriteLine($"{digit1}|{digit2}|{digit4}|{digit5}");



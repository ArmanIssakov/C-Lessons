// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа:
// 78 -> 8
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка (10 -> 99) {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit == secondDigit) Console.WriteLine("Числа равны");
// else{
// // int max = firstDigit;
// // if (secondDigit > max) max = secondDigit;
// Console.Write($"Наибольшая цифра числа {number} => ");
// Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);
// };

int MaxDigit(int num)
{
int firstDigit = num / 10;
int secondDigit = num % 10;
if(firstDigit == secondDigit) return -1;
return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
string result = maxDigit != -1 ? maxDigit.ToString() : "Цифры равны";
Console.Write($"Наибольшая цифра числа {number} =>{result} ");

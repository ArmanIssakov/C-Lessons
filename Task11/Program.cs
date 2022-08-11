// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.
int number =new Random().Next(100, 1000);
Console.WriteLine($"Наше случайное число {number}");
int DeleteMiddleDigit(int num)
{
    int firstDigit = number / 100;
    int thirstDigit = number % 10;
    return firstDigit * 10 + thirstDigit;
}
int result = DeleteMiddleDigit(number);
Console.WriteLine($"После удаления второго числа у нас получается {result}");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num)
{
    if(num == 0) return;
    NaturalNumber(num -1);
    Console.Write($"{num} ");
}
NaturalNumber(number);
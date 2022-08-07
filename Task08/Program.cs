// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите целое число N для нахождения всех четных чисел от 1 до N:");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int number = 0;
while (N <= 1){
  Console.Write("Введенное вами число является меньше 1 или равно 1, введите положительное число больше 1:");
  int boofN = Convert.ToInt32(Console.ReadLine());
  N = boofN;
};
Console.Write($"Четные числа в промежутке от (1) до ({N}):");

while(count < N){
    number = number + 2;
    Console.Write($" {number},");
    count = count + 2;

};


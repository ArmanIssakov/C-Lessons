﻿// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.Write("Введите число N для вывода всех целых чисел в прожутке от -N до N: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N < 0){
    N = N * -1;
}
else{
    N = N * 1;
};
int boofN = N * -1;
Console.Write($"Ваш промежуток чисел: {boofN},");
while(boofN < N){
    boofN = boofN +1;
    Console.Write($" {boofN},");

};
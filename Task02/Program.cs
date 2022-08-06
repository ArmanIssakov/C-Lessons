// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите первое число:");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число:");
double number2 = Convert.ToDouble(Console.ReadLine());
if(number1 == number2){
Console.Write($"Число {number1} равно {number2}");
}
else if(number1 > number2) {
    double max = number1;
    double min = number2;
    Console.Write($"Число {max} больше числа {min}");
}
else {
    double max = number2;
    double min = number1;
    Console.Write($"Число {max} больше числа {min}");
};


// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.Write("Введите трехзначное число для определения последней цифры этого числа:");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0){
    number = number * -1;
}
else{
    number = number * 1;
};
while(number < 100){
    Console.Write("Введенное вами число является не трехзначным, введите пожалуйста трехзначное число:_");
    int boofNumber0 = Convert.ToInt32(Console.ReadLine());
    if(boofNumber0 < 0){
    boofNumber0 = boofNumber0 * -1;
    }
    else{
    boofNumber0 = boofNumber0 * 1;
    };
    number = boofNumber0;
};
while(number >= 1000){
    Console.Write("Введенное вами число является не трехзначным, введите пожалуйста трехзначное число:_");
    int boofNumber1 = Convert.ToInt32(Console.ReadLine());
    if(boofNumber1 < 0){
    boofNumber1 = boofNumber1 * -1;
    }
    else{
    boofNumber1 = boofNumber1 * 1;
    number = boofNumber1;
    // if (number < 100){
    // Console.Write("Введенное вами число является не трехзначным, введите трехзначное число:");
    // int boofNumber2 = Convert.ToInt32(Console.ReadLine());
    // number = boofNumber2;  
    // }
    // else if(number >= 1000){
    // Console.Write("Введенное вами число является не трехзначным, введите трехзначное число:");
    // int boofNumber3 = Convert.ToInt32(Console.ReadLine());
    // number = boofNumber3;  
    // };
};
};
if(number < 0){
    number = number * -1;
}
else{
    number = number * 1;
};
if(number < 100){
    Console.WriteLine("Я же просил вас ввести трехзначное число, а вы :(. Прощайте.");
}
else{
    int result = number % 10;
    Console.WriteLine($"Последней цифрой трехзначного числа {number} является {result}.");
};
// else{
// Console.WriteLine("Введенное вами число является не трехзначным.");   
// };
﻿// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 2)
{
    for (int i = 2; number >= i; i += 2)
    {
        Console.WriteLine($"{i}");
    }
}
else
{
    Console.WriteLine("Число введено некорректно!");
}



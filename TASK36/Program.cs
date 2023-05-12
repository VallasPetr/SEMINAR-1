﻿// Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов). 
// Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[5];
int SumOddIndex = 0;
for (int i = 0; array.Length > i; i++)
{
    int randomNumber = new Random().Next(100, 1000);
    array[i] = randomNumber;
    if (i % 2 == 1)
    {
        SumOddIndex += array[i];
    }
    Console.Write(array[i] + " ");

}

Console.WriteLine();
Console.Write($"Сумма чисел на нечётных индексах = {SumOddIndex}");


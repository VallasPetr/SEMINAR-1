﻿// Задайте массив заполненный случайными положительными трёхзначными числами (длина массива 5 элементов). 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] RandomArray(int from, int to, int lengthArray)
{
    int[] array = new int[lengthArray];
    for (int i = 0; array.Length > i; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}

int CounterEven(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) countEven++;
    }
    return countEven;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, "); // array.Length-1 для вывода всех элементов, 
        else Console.Write($"{array[i]}]");                       // кроме последнего чтобы избежать запятой в конце
    }                                                             // последнего элемента. Последний элемент выводится 
                                                                  // через else c квадратной скобкой в конце
}


int[] array = RandomArray(100, 999, 5); // Вызов метода построения массива случайных чисел

int counterEven = CounterEven(array);   // Вызов метода подсчёта чётных чисел в массиве

PrintArray(array);                      // Вызов метода вывода массива

Console.WriteLine();

Console.WriteLine($"Количество чётных чисел = {counterEven}");
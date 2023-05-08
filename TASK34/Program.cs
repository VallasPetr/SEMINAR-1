// Задайте массив заполненный случайными положительными трёхзначными числами (длина массива 5 элементов). 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[5];
int count = array.Length;
for (int i = 0; count > i; i++)
{
    int randomNumber = new Random().Next(100, 1000);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}

Console.WriteLine();

int countEven = 0;
for (int i = 0; i < count; i++)
{
    if (array[i] % 2 == 0) countEven = countEven + 1;
}
Console.WriteLine($"Количество чётных чисел = {countEven}");
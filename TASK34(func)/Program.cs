// Задайте массив заполненный случайными положительными трёхзначными числами (длина массива 5 элементов). 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array=RandomArray(1, 3, 5);

int[] RandomArray(int from, int to, int lengthArray)
{
int[] array = new int[lengthArray];
for (int i = 0; array.Length > i; i++)
{
    array[i] = new Random().Next(from, to+1);    
}
return array;
}

for(int i=0;i<array.Length;i++)
{
    Console.Write(array[i] + " ");
}
int count = array.Length;
int countEven = 0;
for (int i = 0; i < count; i++)
{
    if (array[i] % 2 == 0) countEven++;
}
Console.WriteLine($"Количество чётных чисел = {countEven}");

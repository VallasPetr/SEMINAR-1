// Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов). 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] RandomArray(int from, int to, int lengthArray)
{
    int[] array = new int[lengthArray];
    for (int i = 0; array.Length > i; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}

int FindMaxArray(int[] array)
{
    int max = array[0];
    for (int i = 0; array.Length > i; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int FindMinArray(int[] array)
{
    int min = array[0];
    for (int i = 0; array.Length > i; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int DiffMaxMin(int max, int min)
{
    int diff = max - min;
    return diff;
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

int[] array = RandomArray(-100, 100, 5);
PrintArray(array);
Console.WriteLine();
int findMinArray=FindMinArray(array);
Console.WriteLine($"Минимальное значение в массиве = {findMinArray}");
int findMaxArray=FindMaxArray(array);
Console.WriteLine($"Максимальное значение в массиве = {findMaxArray}");
int max = findMaxArray;
int min = findMinArray;
int diffMaxMin = DiffMaxMin(max, min);
Console.WriteLine($"Разница между максимальным и минимальным значением массива = {diffMaxMin}");

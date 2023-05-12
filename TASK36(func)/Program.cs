// Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов). 
// Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray(int from, int to, int lengthArray)
{
    int[] array = new int[lengthArray];
    for (int i = 0; array.Length > i; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}

int SumOddIndex(int[] array)
{
    int sumOddIndex=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            
            sumOddIndex += array[i];
        }
        
    }
    return sumOddIndex;
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

int[] array = RandomArray(100, 999, 5);
int sumOddIndex = SumOddIndex(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечётных индексах = {sumOddIndex}");












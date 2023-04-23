// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array_1 = new int[8];

FillArray(array_1);
PrintArray(array_1);

void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(0, 2); // 0 и 1
        index++;
    }
}

void PrintArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}




// Задайте массив из 10 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите суммы отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// Вариант без функций:

Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-9, 10);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}

int sumneg = 0;
int sumpoz = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        sumneg = sumneg + array[i];
    }
    if (array[i] > 0)
    {
        sumpoz = sumpoz + array[i];
    }
}

Console.WriteLine($"сумма положительных равна {sumpoz}");
Console.WriteLine($"сумма отрицательных равна {sumneg}");

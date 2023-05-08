// Задайте массив из 10 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите суммы отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// Вариант с функциями:

Console.WriteLine("Ввндите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
RandNumberArray(array);
DecitionArray(array);
PrintArray(array);
void RandNumberArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
         array[i] = new Random().Next(-9, 9);

    }
}
void DecitionArray(int[] array, int sum = 0, int sub = 0)
{ 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];

        }
        else 
        {
            sub -= array[i];


        }
    }
    Console.WriteLine($"Сумма положительных чисел в массиве равен {sum}, сумма отрицательных чисел равен {sub}");

}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
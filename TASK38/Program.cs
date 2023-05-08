// Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов). 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[5];
int count = array.Length;
for (int i = 0; count > i; i++)
{
    int randomNumber = new Random().Next(-100,101);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}
int max=array[0];
for(int i=0; count>i;i++)
{
    
    if(array[i]>max) max=array[i];
}
Console.WriteLine();
Console.WriteLine($"Максимальное значение в массиве = {max}");

int min=array[0];
for(int i=0; count>i;i++)
{
    
    if(array[i]<min) min=array[i];
}
Console.WriteLine($"Минимальное значение в массиве = {min}");
Console.WriteLine($"Разница между максимальным и минимльным значением = {max-min}");
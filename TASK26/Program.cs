// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
int i = 1;
while (i <= N)
{
    factorial = factorial * i;
    i++;
}

Console.WriteLine(factorial);

// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int summ = 0;
int i = 0;
while (i <= N)
{
    summ = summ + i;
    i++;
}

Console.WriteLine(summ);

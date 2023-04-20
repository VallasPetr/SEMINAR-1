// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число N: ");
string text_N = Console.ReadLine();
double N = Convert.ToInt32(text_N);
double x = 0;
double y = 0;
while (x <= N)
{
    y = Math.Pow(x, 2);
    Console.WriteLine(y);
    x++;
}

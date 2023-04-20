// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка и показывает диапазон возможных координат точек в этой четверти (x и y).
// A (2, 3) -> 1 четверть, x > 0, y > 0
// A (-5, -8) -> 3 четверть, x < 0, y < 0

Console.WriteLine("Введите ось х : ");
string text = Console.ReadLine();
int x = Convert.ToInt32(text);
Console.WriteLine("Введите ось у : ");
string text_1 = Console.ReadLine();
int y = Convert.ToInt32(text_1);

if(x == 0 || y == 0)
{
    Console.WriteLine(" Нуль не вводи ");
}

if(x < 0 && y < 0)
{
    Console.WriteLine("3-ая четверть");
}
if(x < 0 && y > 0)
{
    Console.WriteLine("2-ая четверть");
}
if(x > 0 && y < 0)
{
    Console.WriteLine("4-ая четверть");
}
if(x > 0 && y > 0)
{
    Console.WriteLine("1-ая четверть");
}


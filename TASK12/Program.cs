// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число");
string text_a = Console.ReadLine();
int a = Convert.ToInt32(text_a);
Console.WriteLine("Введите второе число");
string text_b = Console.ReadLine();
int b = Convert.ToInt32(text_b);
int sf = a % b;
if (sf == 0)
{
    Console.Write(" кратно ");
}

if (sf != 0)
{
    Console.Write("Не кратно, остаток от деления : ");
    Console.Write(sf);
}
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 ->  Пятница

Console.Write("Введите номер дня недели: ");
string text = Console.ReadLine();
int numberDayOfWeek = Convert.ToInt32(text);


if (numberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник");
}
if (numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
if (numberDayOfWeek == 3)
{
    Console.WriteLine("Среда");
}
if (numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
if (numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
if (numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
if (numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}

// Console.WriteLine("Какое-то сообщение");

if (numberDayOfWeek < 1)
{
    Console.WriteLine("Нет такого дня");
}

if (numberDayOfWeek > 7)
{
    Console.WriteLine("Нет такого дня");
}

// алтернативное решение
// Console.Write("Введите номер дня недели: ");
// string text = Console.ReadLine();
// int numberDayOfWeek = Convert.ToInt32(text);


// if (numberDayOfWeek == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (numberDayOfWeek == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (numberDayOfWeek == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (numberDayOfWeek == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (numberDayOfWeek == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (numberDayOfWeek == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (numberDayOfWeek == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Нет такого дня");
// }

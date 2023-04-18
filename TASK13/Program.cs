// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
while(num>1000)
{
    num=number/10;
    number = num;
}

if(number>99)
{
    int num1 = number % 10;
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
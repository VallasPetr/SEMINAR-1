// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0 && number<8)
{
    if (number==1) Console.WriteLine("НЕТ");
    if (number==2) Console.WriteLine("НЕТ");
    if (number==3) Console.WriteLine("НЕТ");
    if (number==4) Console.WriteLine("НЕТ");
    if (number==5) Console.WriteLine("НЕТ");
    if (number==6) Console.WriteLine("ДА");
    if (number==7) Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ ТАКОГО ДНЯ НЕДЕЛИ");
}
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
string text_a = Console.ReadLine();
int a = int.Parse(text_a);

if(a % 7 == 0 && a % 23 ==0)
{
     Console.Write("число кратно 7 и 23");
}
else
{
    Console.Write("число не кратно 7 и 23");
}
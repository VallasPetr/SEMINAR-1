// Задача 1. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int n1 = new Random().Next(100, 1000);
Console.WriteLine(n1); 
int n2 = (n1 % 10) + ((n1 / 100) * 10); 
Console.WriteLine(n2); 
// или int number = new Random().Next(100, 1000); 
// Console.WriteLine("Случайное число: " + number); 
// int first = number / 100;
// int second = number % 10; 
// Console.WriteLine("Число без средней цифры"); 
// Console.Write(first); Console.Write(second);
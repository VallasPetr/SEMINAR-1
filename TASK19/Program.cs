// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. (палиндром - число читается слева направо и справа налево одинаково)
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Первый вариант

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

// int a = number / 10000;
// int b = number % 10;
// int c = (number / 1000) % 10;
// int d = (number / 10) % 10;
// if (number >= 10000 && number <= 99999)
// {
//     if (a == b && c == d)
//     {
//         Console.Write("Да");
//     }
//     else
//     {
//         Console.Write("Нет");
//     }
// }
// else
// {
//     Console.Write("Введено некорректное число");
// }

// Второй способ
if (number >= 10000 && number <= 99999)
{
    int palindrome = Palindrome(number);
    string result = palindrome == 1
                                  ? "Да"
                                  : "Нет";
    Console.Write(result);
    int Palindrome(int num)
    {
        int a = num / 10000;
        int b = num % 10;
        int c = (num / 1000) % 10;
        int d = (num / 10) % 10;
        if (a == b && c == d) return 1;
        return 0;
    }
}
else
{
    Console.Write("Введено некорректное число");
}
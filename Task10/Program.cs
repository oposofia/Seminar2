// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = SecondDigit (number);
// int firstDigit = number / 100;
// int secondDigit = number % 100 / 10;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;
Console.WriteLine($"Вторая цифра> -> {secondDigit}");

int SecondDigit(int num)
{
    int Digit2 = number % 100 / 10;
    return Digit2;
}
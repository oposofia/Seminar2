﻿// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");

int del = DeleteSecondDigit (number);
// int firstDigit = number / 100;
// int secondDigit = number % 100 / 10;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;
Console.WriteLine($"Без второй цифры> -> {del}");

int DeleteSecondDigit(int num)
{
    int firstDigit = number / 100;
    int secondDigit = number % 100 / 10;
    int thirdDigit = number % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}
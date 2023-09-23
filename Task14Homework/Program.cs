// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine($"Третья цифра = {NumberThird(number)}");

int NumberThird(int num)
{
    if (num > 999) 
    {
        // int number3digit = num / 10;
        while (num > 999)
        {
            num /= 10;
        }
    }
    int remains = num % 10;
    return remains;
}



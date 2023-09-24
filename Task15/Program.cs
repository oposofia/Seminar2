// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

bool day = DayOfWeek(number);
bool result = Weekand(number);
if (day == true) Console.WriteLine ("Некорректный ввод");
else Console.WriteLine(result ? "это выходной" : "это не выходной");

bool DayOfWeek (int num)
{
    if ((num<1) || (num>7)) return true;
    return false;
}

bool Weekand (int num)
{
    if ((num == 6) || (num == 7)) return true;
    else return false;
}
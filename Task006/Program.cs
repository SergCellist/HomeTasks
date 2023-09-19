// Задача 6.
// Напишите программу которая на вход принимает число и выдаёт, является ли оно чётным (делится ли оно на 2 без отстатка)
// 4 -> да
// -3 -> нет
// 7 > нет


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
Console.WriteLine($"{number} -> да");
}
else 
Console.WriteLine($"{number} -> нет");
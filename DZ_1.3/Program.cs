﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число для определения четное оно или нет: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 1)
{
    Console.WriteLine("Число " + number + " является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + number + " является: ЧЁТНЫМ");
}

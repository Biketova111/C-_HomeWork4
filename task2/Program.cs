/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12; */

using System;
using System.Globalization;
using System.Runtime.CompilerServices;

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число или веденое число меньше нуля. Повторите ввод.");
        }
    }
    return result;
}

int GetSumDigits (int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number%10;
        number = number/10;
    }
    return result;
}



int number = GetNumber("Введите число: ");
int sumDigits = GetSumDigits(number);
Console.WriteLine($"суммa цифр в числе {number} равна {sumDigits}");
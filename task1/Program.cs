/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/


using System.Reflection;

int GetNumber(string message)
{
    
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse (Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Повторите ввод.");
        }
    }
    return result;
}

int GetNumberInPower(int numberOne, int numberTwo)
{
    int result = 1;

 for (int i = 0; i < Math.Abs(numberTwo); i++)
 {
    result = result*numberOne;
 }
 return result;
}


int numberA = GetNumber("Введите число А: ");
int numberB = GetNumber("Введите число B: ");
int numberInPower = GetNumberInPower(numberA, numberB);
Console.WriteLine($"Число A в натуральную степень B  = {numberInPower}");

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


// Console.WriteLine ("Введите числовые элементы массива через запятую: ");


using System.Reflection.Metadata.Ecma335;
using System.Timers;

string GetArrayElements (string message) // проверка правильности ввода
{
    Console.WriteLine(message);
    string ArrayElements = Console.ReadLine();
    int length = ArrayElements.Length;
    string resultArrayElement = String.Empty;

for (int i = 0; i < length; i++) 
{
    if (Char.IsNumber(ArrayElements[i]) == true || ArrayElements[i] == ',' || ArrayElements[i] == ' ')
    {
        resultArrayElement = resultArrayElement + $"{ArrayElements[i]}";
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Введите числовые элементы массива через запятую: ");
        resultArrayElement = String.Empty;
        break;
    }
}

return resultArrayElement; 
} 

string removeSpaces (string ArrayElements) // Удаление пробелов в строке
{
    int len = ArrayElements.Length;
    string resArrayElemet = String.Empty;

    for (int i = 0; i < len; i++)
    {
        if (ArrayElements[i] == ' ')
        {
        }
        else 
        {
            resArrayElemet = resArrayElemet + $"{ArrayElements[i]}";
        }
    }
    return resArrayElemet;
} 

void GetNumberArray(string ArrayElement) // заполнение массива, вывод на печать
{
  ArrayElement += ',';
  string [] NumberArray = ArrayElement.Split(new char [] {','});
  
   Console.Write ("[");
   for (int i = 0; i < NumberArray.Length-1; i++)
   {
        Console.Write ($"{NumberArray[i]} ");
   }
   Console.WriteLine ("]");
 }



string arr = GetArrayElements ("Введите числовые элементы массива через запятую: ");
Console.WriteLine();
arr = removeSpaces(arr);
GetNumberArray(arr);


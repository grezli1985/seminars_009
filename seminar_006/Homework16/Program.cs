﻿/* Задача 41:
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2       
-1, -7, 567, 89, 223-> 3      */


void Zadacha41()
{
    Console.Write("Введите числа: Например: 45 0 4 56 23 -45 34 ");
    Console.WriteLine();
    Console.Write("Введите числа(через пробел): ");
    int[] arr = Array.ConvertAll(
        Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries),
        int.Parse);
    CountNumbers(arr);
}

void CountNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во чисел больше 0 = {count}");
}

Zadacha41();
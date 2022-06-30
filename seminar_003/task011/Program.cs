/*Задача 17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.  */
void Zadacha17()
{
    Console.WriteLine("Введите число x");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число y");
    int y = Convert.ToInt32(Console.ReadLine());

    if      (x > 0 && y > 0) Console.WriteLine("Первая четверть");
    else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
    else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
    else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
    else Console.WriteLine("Точака лежит на кооординатной прямой");
}

Zadacha17();

/* Задача 43.
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения k1, b1, k2 и b2 задаются пользователем.
k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -5,5)  */

void Zadacha43()
{
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    IntersectionPoint(k1, b1, k2, b2);
}

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}

Zadacha43();

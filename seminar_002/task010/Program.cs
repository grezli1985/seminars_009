/*16. Напишите программу, 
которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет */

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Zadacha16(numberA, numberB);

void Zadacha16(int a, int b)
{
    if (b == a*a && a == b*b)
    {
        Console.WriteLine($"{b} является квадратом {a}");
    }
    else
    {
        Console.WriteLine($"{b} не является квадратом {a}");
    }
}

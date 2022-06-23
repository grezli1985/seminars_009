/* Задача 2: Напишите программу, 
которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3    */

Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 2.");


Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
//int numberA = 5;
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
//int numberB = 7;
int max = 0;
int min = 0;
if (numberA > numberB) 
{
    max = numberA;
    min = numberB;
}
else
{
    min = numberA;
    max = numberB;
}
Console.Write("min = ");
Console.WriteLine(min);
Console.Write("max = ");
Console.WriteLine(max);



/* Задача 4: Напишите программу, 
которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22     */

//int numberA = 2;
//int numberB = 3;
//int numberC = 7;
int max = 0;

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberС = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) max = numberA;
if (numberB > numberС) max = numberB;
if (numberС > numberA) max = numberС;

Console.Write("max = ");
Console.WriteLine(max);


/* Задача 1. 
Написать программу, которая определяет,
является ли треугольник со сторонами a, b, c равнобедренным. */

/*Если в треугольнике две стороны равны, 
то он равнобедренный (по определению).*/
// (a == b && a == c && b == c);
// (ab == bc & bc == ad);
Console.WriteLine("Если в треугольнике две стороны равны, то он равнобедренный (по определению).");
Console.Write("Первая сторона треугольника a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая сторона треугольника b = ");
int b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Третья сторона треугольника c = ");
//int c = Convert.ToInt32(Console.ReadLine());
            
if (a == b)    // if (a == b && a == c && b == c);
{
    Console.WriteLine("Равнобедренно");
}
else
{
    Console.WriteLine("Не равнобедренно");
}
       

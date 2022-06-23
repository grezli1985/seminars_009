// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB == numberA*numberA)
{
    Console.WriteLine("Первое число является квадратом второого");
}
else
{
    Console.WriteLine("Первое число не является квадратом второого");
}




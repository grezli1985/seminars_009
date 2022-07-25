/* Задача 66: 
Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */ 


 void Zadacha66()
{   
    Console.Write("Введите число m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Сумма чисел от {m} до {n} ровна: ");
    SumNumbers(m, n);
    Console.WriteLine();
}

void SumNumbers(int m, int n, int sum = 0)
{
    if (m > n)
    {
        Console.Write(sum);
        return;
    }
    sum += m;
    m++;
    SumNumbers(m, n, sum);
}

Zadacha66();

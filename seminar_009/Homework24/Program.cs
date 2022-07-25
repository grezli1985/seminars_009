/* Задача 64:
Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N, кратные трём. */

void Zadacha64()
{
    Console.Write("Видите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Видите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    MultiplesOfThree(M, N);
    Console.WriteLine();
}

void MultiplesOfThree(int m, int n)
{
    if(m > n) return;
    if(m % 3 == 0)
    Console.Write(m + "\t");
    m++;
    MultiplesOfThree(m, n);
}



Zadacha64();

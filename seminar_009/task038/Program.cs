/* Задача 65: 
Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N. */ 

void Zadacha65()
{

    int n = 4;
    int m = 15;
    Recursion(n, m);

    void Recursion(int n, int m)
    {
        if (m - 1 < n) return;
        n++;
        Console.Write(n - 1 + " ");
        Recursion(n, m);
    }   
}

Zadacha65();

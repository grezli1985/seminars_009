/* Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

          /  n + 1                 m = 0
A(m,n) = |   A(m-1,1)              n = 0
          \  A(m - 1,A(m,n -1))    m,n = 0

m = 3, n = 2 -> A(m,n) = 29      */


void Zadacha68()
{
    int m = 3;
    int n = 2;
    Console.Write($"Функция Аккермана = {AckermanFunction(m, n)} ");
    Console.WriteLine();
}

int AckermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermanFunction(m - 1, 1);
  else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Zadacha68();

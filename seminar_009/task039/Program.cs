/* Задача 67: 
Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр. */ 


void Zadacha67()
{
    Console.Write("Видите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    Recursion(n);


    void Recursion(int n, int sum = 0)
    {
        if (n == 0)
        {
            Console.WriteLine(sum);
            return;
        }
       
        sum += n % 10;
        n  /= 10;
        Recursion(n, sum);
    }   

}

Zadacha67();
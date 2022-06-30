/*Задача 22: Напишите программу,
которая принимает на вход число (N) и
выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

void Zadacha22()
{   
        Console.WriteLine("Введите число ");
        int number = Convert.ToInt32(Console.ReadLine());
    
        int index = 1;
        while (index <= number)
        {
            Console.Write(index * index);
            index++;
        } 
        Console.WriteLine();
}     

Zadacha22(); 

/*
void Zadacha22(int n)
{    
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i + " ");
    }
    Console.WriteLine();
}

Zadacha22(10);  */

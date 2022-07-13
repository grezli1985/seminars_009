/*Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125 */ 

/*
void Zadacha23()
{   
        Console.WriteLine("Введите число ");
        int number = Convert.ToInt32(Console.ReadLine());
    
        int index = 1;
        while (index <= number)
        {
            Console.Write($"{index * index * index} ");
            index++;
        } 
        Console.WriteLine();
}     

Zadacha23();    */

void Zadacha23()
{
    int number = 12;

    for(int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)} ");  
    }
    Console.WriteLine();
}
Zadacha23();
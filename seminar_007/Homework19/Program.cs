/* Задача 50: 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет. 
Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    1, 3 -> 3       */ 

void Zadacha50()
{
    int rows = 4;
    int columns = 5;
    int[,] array = new int[rows, columns]; 

    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);
    TakesPositionsReturnsValue(array);

}

void TakesPositionsReturnsValue(int[,] array)
{
    Console.Write("Виберите строку: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Виберите столбик: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int j = 0;
    int i = 0;


    for (i = 0; i < a; i++){}
        for (j =0; j < b; j++){}  
    if(a < i | a > array.GetLength(0) - 1 | b < j | b > array.GetLength(1) - 1)
    {
        Console.Write("такого элемента нет ");
        Console.WriteLine();
    }
    else 
    {
        Console.Write($"Строка {i} столбик {j} ваша цифра {array[i, j]}");
        Console.WriteLine();
    }
}

void FillArray(int[,] array, int rows, int columns)
{
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array, int rows, int columns)
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " |" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    
}

Zadacha50();

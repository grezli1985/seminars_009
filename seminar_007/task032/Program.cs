/* Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами (0,0);
(1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */ 


void Zadacha51()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns]; 
    FillArray(array);
    PrintArray(array);
    //SumElements(array);                  // перебор двумя циклами
    SumElements1(array, rows, columns);    // перебор одним циклом
}

void SumElements(int[,] array)     
{
    int sum = 0;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if(i == j)
            {
                sum += array[i, j];
                Console.Write(array[i, j] +  " + ");
            }
            
        }
    }
    Console.Write("\b\b\b");
    Console.Write($" = " + sum);
    Console.WriteLine();
}

void SumElements1(int[,] array, int rows, int columns)  
{
    int sum = 0;
    for (int i = 0; i < rows && i < columns; i++)
    {
        sum += array[i, i];
        Console.Write(array[i, i] +  " + ");
    }
    Console.Write("\b\b\b");
    Console.Write($" = " + sum);
    Console.WriteLine();
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Zadacha51();

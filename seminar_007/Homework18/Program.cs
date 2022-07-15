/* Задача 47: 
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами,
округлёнными до одного знака. 
    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9*/ 

void Zadacha47()
{
    int rows = 3;
    int columns = 4;
    double[,] array = new double[rows, columns]; 
    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);


}

void FillArray(double[,] array, int rows, int columns)
{
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 1);
        }
    }
}

void PrintArray(double[,] array, int rows, int columns)
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Zadacha47();

/* Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

void Zadacha56()
{
    Random random = new Random();
    int rows = random.Next(2, 6);
    int columns = random.Next(4, 6);

    int[,] array = new int[rows, columns];
    int[] sum = new int[rows];

    FillArray(array);
    PrintArray(array);
    LineSum(array, sum);
    SmallestSum(sum);
}
void LineSum(int[,] array, int[] sum)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum[i] += array[i, j];   
        }
        Console.WriteLine($"сумма  {i + 1} строки = {sum[i]}");  
    }
    Console.WriteLine();  
}

void SmallestSum(int[] sum)
{
    int min = sum[0];
    for (int i = 0; i < sum.Length; i++)
    {
        if(min > sum[i]) 
        {
            min = sum[i];
        }
    }
    Console.WriteLine($"наименьшая сумма строки = {min}");    
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
            array[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
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
    Console.WriteLine();
}

Zadacha56();
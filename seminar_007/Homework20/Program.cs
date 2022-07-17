/* Задача 52: 
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:     
    1 4 7 2
    5 9 5 3
    8 4 6 4
Среднее арифметическое
каждого столбца: 4,6; 5,6; 6; 3. */

void Zadacha52()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns]; 
    
    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);
    ArithmeticMean(array, columns, rows);
}

void ArithmeticMean(int[,] array, int columns, int rows)
{
    for (int i = 0; i < columns; i++)
    {
        double m = 0;
        double sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += array[j, i];
            m = sum;
            Console.Write(array[j, i] +  " + ");   
        }
        Console.Write("\b\b");
        sum = Math.Round(sum / rows, 1);
        Console.WriteLine($"= {m} / {rows} = {sum}");
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

Zadacha52();

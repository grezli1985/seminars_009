/* Задача 53:
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */


void Zadacha53()
{

    Random random = new Random();
    int rows = random.Next(2, 6);
    int columns = random.Next(4, 9);

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    WillLine(array, rows, columns);
    PrintArray(array);
}

void WillLine(int[,]array, int rows, int columns)
{
    // int rows = array.GetLength(0);
    // int columns = array.GetLength(1);
    for (int j = 0; j < columns; j++)
    {   
        //(array[0, j], array[rows - 1, j]) = (array[rows - 1, j], array[0, j]);
            int temp = array[rows - 1, j];
            array[rows - 1, j] = array[0, j];
            array[0, j] = temp;
    }
    
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

Zadacha53();
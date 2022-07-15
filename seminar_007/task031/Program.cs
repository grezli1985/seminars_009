/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты. 
1 4 7 2          1 4 7 2
5 9 2 3          5 81 2 9
8 4 2 4          8 4 2 4           */ 


void Zadacha49()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    EvenIndices(array);
    PrintArray(array);
}
void EvenIndices(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if((i % 2 == 0) && (j % 2 == 0))
            {
                array[i, j] *= array[i, j];
            }
        }
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
    Console.WriteLine();
}

Zadacha49();
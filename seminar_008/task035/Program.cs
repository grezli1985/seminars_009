/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */ 


void Zadacha57()
{

    Random random = new Random();
    int rows = random.Next(2, 5);
    int columns = random.Next(3, 5);

    int[,] array = new int[rows, columns];
    int[] dictionary = new int[10];

    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dictionary[array[i, j]] ++;
        }
    }

    for (int i = 0; i < dictionary.Length; i++)
    {
        if(dictionary[i] != 0) Console.WriteLine($"Элемент {i} втречается {dictionary[i]} раз");
    }


}




void FillArray(int[,] array, int rows, int columns)
{
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 10);
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

Zadacha57();
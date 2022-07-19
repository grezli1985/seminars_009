/* Задача 55: 
Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */




void Zadacha53()
{

    Random random = new Random();
    int rows = random.Next(3, 6);
    int columns = random.Next(3, 6);

    int[,] array = new int[rows, columns];
    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);
    ChangeRowsToColumns(array, rows, columns);
    PrintArray(array, rows, columns);

}
void ChangeRowsToColumns(int[,] array, int rows, int columns)
{
    if(rows == columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < columns; j++)
            {
                //(array[i, j], array[j, i]) = (array[j, i], array[i, j]);
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
    }
    else Console.WriteLine("Заменить строки на столбцы невозможно");
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
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " |" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-------------------------");
}

Zadacha53();
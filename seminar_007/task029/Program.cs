/* Задача 46: 
Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

void Zadacha46()
{
    int rows = 4;     // строки
    int columns = 5;   // столбцы
    int[,] array = new int[rows, columns]; // 4 x 5
    FillArray(array);
    PrintArray(array);
}
    // Console.WriteLine(GetLength(0));
    // Console.WriteLine(GetLength(1));
void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)    //array.Length-хорошо  array.GetLength(0)-плохо
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

Zadacha46();
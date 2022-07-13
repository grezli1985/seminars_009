/* Задача 45: 
Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования. */


void Zadacha45()
{
    Random random = new Random();
    int size = random.Next(4, 12);
    int[] array = new int[size]; 
    int[] arraySecond = new int[array.Length];   
    FillArray(array, 0, 10);
    PrintArray(array);
    CopyArray(array);


}

void CopyArray(int[] array)
{
    int[] arraySecond = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {    
        arraySecond[i] = array[i];                     
    }
    PrintArray(arraySecond);
}

void FillArray(int[] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Console.Write("Вывод массива");
    Console.WriteLine();
    Random random = new Random();    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
        
    }
    Console.WriteLine();
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
    
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Zadacha45();
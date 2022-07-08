/* Задача 35: 
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/ 

void Zadacha35()
{
    int size = 123;
    int[] array = new int[size];
    FillArray(array, 1, 200);
    PrintArrayMin(array);
    TheValuesOfWhichLieInTheInterval(array);
}

void TheValuesOfWhichLieInTheInterval(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 99 && array[i] >= 10)
        {
            count++;
        }
    }
    Console.WriteLine(count);
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

void PrintArrayMin(int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
    
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Zadacha35();
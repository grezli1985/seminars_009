/*Задача 37: 
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21  */ 

void Zadacha37()
{
    Random random = new Random();
    int size = random.Next(4, 12);
    int[] array = new int[size];    
    FillArray(array, 0, 10);
    PrintArrayMin(array);
    ProductOfNumberPairs(array);
}

void ProductOfNumberPairs(int[] array)
{
    int maxIndex = array.Length - 1;
    Console.WriteLine();
    for (int i = 0; i < array.Length/2; i++)
    {
        Console.WriteLine($"{array[i]} * {array[maxIndex - i]} = {array[i] * array[maxIndex - i]}");
    }
    if (array.Length % 2 == 1) Console.WriteLine("Элемент без пары: " + array[array.Length/2]);
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

Zadacha37();




/*  Задача 29: Напишите программу, которая задаёт массив
из 8 случайных целых чисел и выводит отсортированный
по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [1, 6, -33]                */

/* void Zadacha29()
{
    int size = 8;
    int[] array = new int[size];
    FillArray(array);
    PrintArrayMin(array);
    PrintArrayMax(array);

}

void FillArray(int[] currentArray)       // Заполнения массива
{
    Random random = new Random();
    Console.WriteLine("Задаём массив: ");
    for(int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = random.Next(-5, 10);
        Console.Write(currentArray[i] + " ");
    }
    Console.WriteLine();
}

void PrintArrayMin(int[] array)          // Отсортированный массив от Min до Max
{
    Console.WriteLine("Вывод отсортированный массив от Min до Max: ");
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
            minPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintArrayMax(int[] array)          // Отсортированный массив от Max до Min
{
    Console.WriteLine("Вывод отсортированный массив от Max до Min: ");
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
            maxPosition = j;
            }
        }
                                               
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
          
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/


void Zadacha29()
{
    int size = 8;
    int[] array = new int[size];
    

    FillArray(array);
    PrintArray(array);
    ModuloSortedArray(array);
    PrintArray(array);
}
void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

void ModuloSortedArray(int[] array)
{
    for (int i = array.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                
            }
        }
    }
}


Zadacha29();

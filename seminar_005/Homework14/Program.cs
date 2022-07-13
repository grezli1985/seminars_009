/* Задача 36:
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0    */

// void Zadacha36()
// {
//     Random random = new Random();
//     int size = random.Next(4, 12);
//     int[] array = new int[size];
//     FillArray(array, -10, 10);
//     PrintArray(array);
//     Console.WriteLine(
//         "Сумму элементов, стоящих на нечётных позициях: " + TheSumOfElementsInOddPositions(array)
//     );
// }

// int TheSumOfElementsInOddPositions(int[] arr)
// {
//     int sum = 0;
//     int i = 1;
//     while (i < arr.Length)
//     {
//         sum += arr[i];
//         i += 2;
//     }
//     return sum;
// }

// void FillArray(int[] array, int startNumber = 0, int finishNumber = 0)
// {
//     finishNumber++;
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(startNumber, finishNumber);
//     }
//     Console.WriteLine();
// }

// void PrintArray(int[] array)
// {
//     Console.Write("Вывод массива");
//     Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Zadacha36();






void Zadacha36()
{
    Random random = new Random();
    int size = random.Next(4, 12);
    int[] array = new int[size];
    FillArray(array, 0, 10);
    PrintArray(array);

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    Console.WriteLine("Сумму элементов, стоящих на нечётных позициях: " +  sum);
}

void FillArray(int[] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
    Console.WriteLine();
}

void PrintArray(int[] array)
{
    Console.Write("Вывод массива");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Zadacha36();

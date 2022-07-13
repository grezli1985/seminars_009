/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2  */

// void Zadacha34()
// {
//     Random random = new Random();
//     int size = random.Next(4, 8);
//     int[] array = new int[size];
//     FillArray(array, 100, 1000);
//     PrintArray(array);
//     NumberOfEvenNumbersInTheArray(array);

// }

// void NumberOfEvenNumbersInTheArray(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             //Console.WriteLine($"{array[i]} число чётное ");
//             count++;
//         }
//         // else
//         // {
//         //     Console.WriteLine($"{array[i]} число нечётное ");
//         // }
//     }

//     Console.WriteLine(count + " - количество чётных чисел в массиве");
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

// Zadacha34();




void Zadacha34()
{
    int[] array = new int[8];
    FillArray(array, 100, 999);
    PrintArray(array);
    CountEvenNumber(array);
}

void CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    Console.WriteLine("Количество четных чисел в массиве: " + count);
}

void FillArray(int[] array, int startNumber = 0, int finishNumber = 1)
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
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}


Zadacha34();
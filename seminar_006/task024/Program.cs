/* Задача 39: 
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]       */ 


void Zadacha39()
{
    int[] array = new int[8];
    //int[] secondArray = new int[array.Length];
    FillArray(array, 1, 10);
    PrintArray(array);
    Console.WriteLine();
    Reverse(array);
    
}  

void Reverse(int[] array)
{ 
    int maxIndex = array.Length - 1;

    for (int i = 0; i < array.Length/2; i++)
    {
        //secondArray[maxIndex - i] = array[i];     // использовать два массива
        // int temp = array[i];                            //ёё/
        // array[i] = array[maxIndex - i];                 //ёё/  использовать один массив + доп переменная
        // array[maxIndex - i] = temp;                     //ёё/
        (array[i], array[maxIndex - i]) = (array[maxIndex - i], array[i]);     // картеж
    }
    PrintArray(array);
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

Zadacha39();
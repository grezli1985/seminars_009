/*Задача 30: Напишите программу, 
которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

void Zadacha30()
{
    int size = 8;
    //int startNumber = 5;
    //int finishNumber = 8;
    int[] array = new int[size];
    //array = FillArrayFunction(size);
    //FillArray(array, startNumber, finishNumber);
    FillArray(array);
    PrintArray(array);
    
}

int[] FillArrayFunction(int size)   // в этом варианте мы работаем с двумя массивами
{
    int[] fillArray = new int[size];

    Random random = new Random();
    
    for (int i = 0; i < fillArray.Length; i++)
    {
        fillArray[i] = random.Next(0, 2);  // 0 1
    }
    return fillArray;
}

//void FillArray(int[] currentArray, int startNumber = 0, int finishNumber = 0)
void FillArray(int[] currentArray)   // заполняем на примую наш массив
{
    //finishNumber++;
    Random random = new Random();    // массив лучше заполнять не в цикле (будет быстрей)  "создовать в цикле не стоит"
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = random.Next(0, 2);  // 0 1
        //currentArray[i] = random.Next(startNumber, finishNumber);
    }
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


Zadacha30();






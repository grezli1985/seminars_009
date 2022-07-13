/* Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76   */      

void Zadacha38()
{     
    Random random = new Random();
    int size = random.Next(4, 12);
    double[] array = new double[size];
    FillArray(array, -1000000000000000000, 10000000000000000000);
    PrintArray(array);
    DifferenceBetweenMaxAndMinArrayElements(array);
    
}


void DifferenceBetweenMaxAndMinArrayElements(double[] arr)
{
    int min = 0;
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > arr[max]) max = i;     
        if (arr[i] < arr[min]) min = i;
        
    }
    Console.WriteLine($"от max = {arr[max]}  вычитаем min = {arr[min]} = получаем разница между max min {arr[max] - arr[min]} " );
}

void FillArray(double[] array, double startNumber = 0, double finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble();                //startNumber, finishNumber
    }
    
    Console.WriteLine();
}


void PrintArray(double[] array)
{
    Console.Write("Вывод массива");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Zadacha38();
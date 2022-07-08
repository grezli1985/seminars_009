/* Задача 32: 
Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие отрицательные, 
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */ 

void Zadacha32()
{
int size = 4;
int[] array = new int[size];
FillArray(array, -10, 10);
PrintArrayMin(array);
ReplacePositiveWithNegative(array);
PrintArrayMin(array);
}

int[] ReplacePositiveWithNegative(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

void FillArray(int[] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void PrintArrayMin(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Zadacha32();



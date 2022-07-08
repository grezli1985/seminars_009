/* Задача 33: 
Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да  */

void Zadacha33()
{    
    Random random = new Random();
    int size = random.Next(4, 12);
    int[] array = new int[size];
    
    FillArray(array, -10, 10);
    PrintArrayMin(array);
    DenisVariant(array);
    //WhetherTheGivenNumbesIsPresentInTheArray(array);
}
void DenisVariant(int[] array)
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string part = "не ";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) part = "";
    }
    Console.WriteLine("искомое число " + part + "содержится в массиве");
}

void WhetherTheGivenNumbesIsPresentInTheArray(int[] array)
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    bool flag = false;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            flag = true;
            break;
        }
    }
    if(flag) Console.WriteLine($"заданное число {number} присутствует в массиве ");
    else Console.WriteLine($"заданное число {number} осутствует в массиве ");
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
    
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Zadacha33();


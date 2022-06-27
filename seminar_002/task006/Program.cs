
//Console.WriteLine("Hello, World!");

Random rand = new Random();
int number = rand.Next(10, 100);
Zadacha9(number);

void Zadacha9(int currentNumber)
{
    Console.WriteLine(currentNumber);
    //96 -> 96/10 = 9    96 % 6 = 6
    int digitFirst = currentNumber/10;
    int digisecond = currentNumber%10;
    if (digitFirst > digisecond)
    {
        Console.WriteLine(digisecond);
    }
    else if (digitFirst < digisecond)
    {
        Console.WriteLine(digisecond);
    }
    else
    {
        Console.WriteLine("ифры числа равны");
    }
}
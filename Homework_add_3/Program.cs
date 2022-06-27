/* Задача 3. 
На ввод подаётся рост трёх спортсменов. 
Расположить их от большего к меньшему. */

/*Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 3. доп");*/

/*Console.WriteLine("Введите рост пловца ");
int growthA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост баскетболиста ");
int growthB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост футболиста ");
int growthC = Convert.ToInt32(Console.ReadLine());*/

//void growth (int[] args)

int[] athletes = new int[] {1, 2, 3}; 
//int[] athletes = new int[] { growthA, growthB, growthC };

int i = 0;
int j = i + 1;

while (i < athletes.Length)
{
    if (j < athletes.Length)
    {
        if (athletes[i] < athletes[j])
        {
            int temp = athletes[i];
            athletes[i] = athletes[j];
            athletes[j] = temp;
        }
    j++;
    }
i++;
return;
}


Console.WriteLine();

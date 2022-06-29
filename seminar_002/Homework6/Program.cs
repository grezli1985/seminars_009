/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным. 

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите число недели");
int numberA = Convert.ToInt32(Console.ReadLine());

void Day(int numberA)
{
    if (numberA == 1)
    {
        Console.WriteLine("Старший братец ПОНЕДЕЛЬНИК -");
        Console.WriteLine("Работяга, не бездельник.,");
        Console.WriteLine("Он неделю открывает,");
        Console.WriteLine("Всех трудиться заставляет.");
    }
    else if (numberA == 2)
    {
        Console.WriteLine("ВТОРНИК следует за братом");
        Console.WriteLine("У него идей богато,");
        Console.WriteLine("Он за все берется смело");
        Console.WriteLine("И работа закипела.");
    }
    else if (numberA == 3)
    {
        Console.WriteLine("Вот и средняя сестрица");
        Console.WriteLine("Не пристало ей лениться,");
        Console.WriteLine("А зовут её СРЕДА,");
        Console.WriteLine("Мастерица хоть куда.");
    }
    else if (numberA == 4)
    {
        Console.WriteLine("Брат ЧЕТВЕРГ и так и сяк,");
        Console.WriteLine("Он мечтательный чудак");
        Console.WriteLine("Повернул к концу недели");
        Console.WriteLine("И тянулся еле еле.");
    }
    else if (numberA == 5)
    {
        Console.WriteLine("ПЯТНИЦА — сестра сумела");
        Console.WriteLine("Побытрей закончить дело.");
        Console.WriteLine("Если делаешь успехи,");
        Console.WriteLine("Время есть и для потехи.");
    }
    else if (numberA == 6)
    {
        Console.WriteLine("Предпоследний брат СУББОТА");
        Console.WriteLine("Не выходит на работу.");
        Console.WriteLine("Шалопай и озорник");
        Console.WriteLine("Он работать не привык.");
        Console.WriteLine("У него другой талант — ");
        Console.WriteLine("Он поэт и музыкант,");
        Console.WriteLine("Да не столяр и не плотник,");
        Console.WriteLine("Путешественник, охотник.");
    }
    else if (numberA == 7)
    {
        Console.WriteLine("В гости ходит ВОСКРЕСЕНЬЕ");
        Console.WriteLine("Очень любит угощение.");
        Console.WriteLine("Это самый младший брат,");
        Console.WriteLine("К Вам зайти он будет рад");
    }
    else Console.WriteLine("Вот неделька, в ней семь дней.");
}

Day(numberA);
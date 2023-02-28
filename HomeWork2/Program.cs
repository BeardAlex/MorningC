// Home work 2

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
    и на выходе показывает вторую цифру этого числа.
*/
/*
int GetTwoNumber(int Number)
{
    return Number / 10 % 10;
}
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int result = GetTwoNumber(num1);
Console.WriteLine($"Вторая цифра числа {num1} это {result}.");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
/*
int GetTreeNumber(int Number)
{
    int result = Number / 100;
    if(result == 0) return -1;
    return result  % 10;
}
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int result = GetTreeNumber(num1);
if(result < 0) Console.WriteLine($"Третьей цифры числа {num1} нет.");
else Console.WriteLine($"Третья цифра числа {num1} это {result}.");
*/


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
*/
/*
bool GetDayOff(int Day)
{
    if(Day == 6 || Day == 7) return true;
    return false;
}
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 1 || num1 > 7) 
    Console.WriteLine("Введено неверное значение (1 - 7).");
else
{
    bool result = GetDayOff(num1);
    if(result) Console.WriteLine("Выходной день.");
    else Console.WriteLine("Рабочий день.");
}
*/
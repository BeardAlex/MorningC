// Home work 3

/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/
/*
bool CheckPalindrome(int value)
{
    // *** Проверка (не используем)
    // *** if(value / 100000 > 0 || value / 1000 == 0) => Ошибка условия. Число не пятизначное
    if(value / 10000 % 10 == value % 10 && value / 1000 % 10 == value / 10 % 10)
        return true;
    return false;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = CheckPalindrome(num);
if(result) Console.WriteLine($"Число {num} являеться полиндромом");
else Console.WriteLine($"Число {num} НЕ являеться полиндромом");
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/
/*
double DistanceBetweenPoints(
    double x1, double y1, double z1,
    double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0);
}

Console.Write("Введите координату x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.Write(Math.Round(DistanceBetweenPoints(x1, y1, z1, x2, y2, z2), 2));
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void NumberCubeTable(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} в кубе равно: " + Math.Pow(count, 3));
        count++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
NumberCubeTable(num);
*/
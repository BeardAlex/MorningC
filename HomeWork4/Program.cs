// Home work 4
/*
///////////////////////////////////////////////////////////////////////////////
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/
/*
double Exponentiate(int num1, int num2)
{
    double result = num1;
    for(int i = 1; i < num2; i++)
        result = result * num1;
    return result;
}

Console.Write("Какое число возводим? ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень? ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Exponentiate(num1, num2));
*/
///////////////////////////////////////////////////////////////////////////////
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

int GetSumDigits(int num)
{
    int result = 0;
    int temp = num;
    while (temp > 0)
    {
        result += temp % 10;
        temp = temp / 10;
    }
    return result;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма цифр числа {num} равна {GetSumDigits(num)}");

///////////////////////////////////////////////////////////////////////////////
/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

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
/*
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
*/
///////////////////////////////////////////////////////////////////////////////
/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
        result[i] = new Random().Next(minValue, maxValue + 1);
    return result;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальное число массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное число массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size, minValue, maxValue));
*/
// Home work 5
/*****************************************************************************/
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
        result[i] = new Random().Next(minValue, maxValue + 1);
    return result;
}
/*****************************************************************************/
/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
*/
/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
        result[i] = new Random().Next(minValue, maxValue + 1);
    return result;
}
int NumberEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 1)
            count++;
    }
    return count;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, 100, 999);
ShowArray(array);
int EvenNumbers = NumberEvenNumbers(array);
Console.WriteLine($"В массиве {EvenNumbers} четных чисел.");
*/
/*****************************************************************************/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int SumOdd(int[] array){
    int result = 0;
    for(int i = 1; i < array.Length; i += 2)
        result += array[i];
    return result;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, 0, 99);
ShowArray(array);
int sumOdd = SumOdd(array);
Console.WriteLine($"Сумма четных элементорв массива равна {sumOdd}.");
*/
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
/*
void ShowArrayDouble(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double FindMax(double[] array){
    double Max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(Max < array[i])
            Max = array[i];
    }
    return Max;
}
double FindMin(double[] array){
    double Min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(Min > array[i])
            Min = array[i];
    }
    return Min;
}
double DiffMaxMin(double[] array){
    return FindMax(array) - FindMin(array);
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] result = new double[size];
for(int i = 0; i < size; i++) {
    Console.Write("Введите очередное число: ");
    result[i] = Convert.ToDouble(Console.ReadLine());
}
ShowArrayDouble(result);
Console.Write($"Разница между максимальным и минимальным значениями массива: {Math.Round(DiffMaxMin(result),2)}");
//Console.Write($"Разница между максимальным и минимальным значениями массива: {FindMin(result)}");
*/
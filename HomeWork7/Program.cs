// Home work 7
// Общие методы **************************************************************.
int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите макимальное возможное значение: .");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] result = new int[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);
    return result;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] CreareRandom2dDouble(int Rows, int Cols, int MinValue, int MaxValue)
{
    double[,] result = new double[Rows, Cols];
    for(int i = 0; i < Rows; i++)
        for(int j = 0; j < Cols; j++)
            result[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(MinValue, MaxValue + 1), 2);
    return result;
} 
void Show2dDouble(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + " ");
    Console.WriteLine();
}
/*****************************************************************************/
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макимальное возможное значение: .");
int maxValue = Convert.ToInt32(Console.ReadLine());
Show2dDouble(CreareRandom2dDouble(rows, cols, minValue, maxValue));
*/
/*****************************************************************************/
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет
*/
/*
void ShowElement(int[,] array, int Col, int Row)
{
    if(array.GetLength(0) < Col || array.GetLength(1) < Row)
        Console.WriteLine($"Элемента в позиции {Col} : {Row} не существует!");
    else
        Console.WriteLine($"Значение элемента в строке {Col} и колонке {Row} равно: {array[Col-1, Row-1]}");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.WriteLine();
Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int col = Convert.ToInt32(Console.ReadLine());
ShowElement(newArray, col, row);
*/



/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
double[] Average(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        result[i] = sum/(double)array.GetLength(0); // Без преобразования отбрасывает дробную часть почему то 
    }
    return result;
}
int[,] array = CreateRandom2dArray();
Show2dArray(array);
double[] result = Average(array);
ShowDoubleArray(result);
*/



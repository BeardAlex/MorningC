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
*/

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
*/

/*
void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}


int[,] newArray = CreateRandom2dArray(10, 10, 1, 100);
Show2DArray(newArray);
*/


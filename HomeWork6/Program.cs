// Home work 6
/*****************************************************************************/
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
int GetNumberPositive()
{
    Console.Write("Сколько чисел вы хотите ввести? ");
    int amount = Convert.ToInt32(Console.ReadLine());
    if (amount < 1)
        return -1;
    int count = 0;
    for (int i = 1; i <= amount; i++)
    {
        Console.Write($"Введите {i} число  из {amount}: ");
        if (Convert.ToInt32(Console.ReadLine()) > 0)
            count++;
    }
    return count;
}
int result = GetNumberPositive();
if (result != -1)
    Console.Write($"Вы ввели {result} положительных чисел.");
else
    Console.Write($"Неверный ввод. Повторите попытку");
*/
/*****************************************************************************/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
bool CheckLines(double k1, double b1, double k2, double b2)
{
    if(k1 == k2)
    {
        if(b1 == b2)
        {
            Console.WriteLine("Совпадающие прямые.");
            return false;
        }
        else
        {
            Console.WriteLine("Параллельные прямые.");
            return false;
        }
    }
    return true;
}
double[] IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double[] result = new double[2];
    result[0] = (b1 - b2) / (k2 - k1);
    result[1] = k1 * result[0] + b1;
    return result;
}
Console.Write("Введите коэффицент для первой прямой: .");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кконстанту для первой прямой: .");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффицент для второй прямой: .");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кконстанту для второй прямой: .");
double b2 = Convert.ToDouble(Console.ReadLine());

if(CheckLines(k1, b1, k2, b2))
{
    double[] point = IntersectionPoint(k1, b1, k2, b2);
    Console.WriteLine($"Точка пересечения заданных прямых: x = {point[0]} и y = {point[1]}.");
}
*/
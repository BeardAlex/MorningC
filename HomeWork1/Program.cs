// Home work 1

/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
    Console.WriteLine($"{num1} больше чем {num2}.");
else if (num2 > num1) 
    Console.WriteLine($"{num2} больше чем {num1}.");
else
    Console.WriteLine($"Числа {num1} и {num2} равны.");
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
/*
int max = 0;
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) max = num1;
else max = num2;
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num3 > max) max = num3;
Console.WriteLine($"{max} максимальное из трех чисел.");
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
    Console.WriteLine($"{num} четное число.");
else
    Console.WriteLine($"{num} не четное число.");
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
*/
/*
int count = 2;
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (count <= num)
{
    Console.Write($"{count}; ");
    count = count + 2;
}
*/

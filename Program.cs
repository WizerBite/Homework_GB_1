//  Задание 2
//  Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

/*
Console.WriteLine("Введите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine()), 
    b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное число: ");
if (a > b)
{ 
    Console.WriteLine(a); 
    Console.WriteLine("Минимальное число: ");
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(b);
    Console.WriteLine("Минимальное число: ");
    Console.WriteLine(a);
}
*/


//  Задание 4
//  Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Введите 3 числа: ");
int a = Convert.ToInt32(Console.ReadLine()),
    b = Convert.ToInt32(Console.ReadLine()),
    c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное число: ");
if (a > b)
{
    if (a > c)
        Console.WriteLine(a);
    else
        Console.WriteLine(c);
}
else
{
    if (b > c)
        Console.WriteLine(b);
    else
        Console.WriteLine(c);
}
*/


//  Задание 6
//  Напишите программу, которая на вход принимает число
//  и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
    Console.WriteLine("Число является четным");
else
    Console.WriteLine("Число не является четным");
*/


//  Задание 8
//  Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

/*
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
for (int i = 2; i < a + 1; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);
*/
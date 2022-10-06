// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine()!);
int y = 2;

while (y <= x)
{
    Console.Write($"{y} ");
    y = y + 2;
}
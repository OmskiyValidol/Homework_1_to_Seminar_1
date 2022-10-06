// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int z = int.Parse(Console.ReadLine()!);
int max = 0;

if (x > y)
{
    max = x;
}
else
{
    max = y;
}
if (y > x)
{
    max = y;
}
else
{
    max = x;
}
if (z > x)
{
    max = z;
}
else
{
    max = x;
}
if (z > y)
{
    max = z;
}
else
{
    max = y;
}
Console.WriteLine($"Максимальное число = {max}");
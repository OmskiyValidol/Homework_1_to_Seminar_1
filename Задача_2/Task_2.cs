﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine($"Это число {num1} больше этого числа {num2}");
}
else if (num2 > num1)
{
    Console.WriteLine($"Это число {num2} больше этого числа {num1}");
}
else if (num1 == num2)
{
    Console.WriteLine("Числа равны, попробуйте заново");
}
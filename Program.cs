/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Решаем с помощью "/" и "%", со строками не работаем */

Console.WriteLine("Введите число:");
int number1 = int.Parse(Console.ReadLine()!);
int num2 = number1 % 100;
int num3 = num2 / 10;
Console.WriteLine($"Вторая цифра {number1} {num3}");
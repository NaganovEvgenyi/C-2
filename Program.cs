/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Решаем с помощью "/" и "%", со строками не работаем
    
        

Console.WriteLine("Введите число:");
        int num1 = int.Parse(Console.ReadLine()!);
        int num2 = num1 % 100;
        int num3 = num2 / 10;
        if ((num1 >= 100) && (num1 <= 999))
        {
            Console.WriteLine($"Вторая цифра {num1} = {num3}");
        }
        else if (num1 <= 99) 

            Console.WriteLine("Ошибка необходимо ввести трехзначное число");
        
        else if (num1 >= 999) 

            Console.WriteLine("Ошибка необходимо ввести трехзначное число");
        
        
         Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
         Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)
         */

         
         
         
         
Console.WriteLine("Введите число:");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = num1 / 10;
int num3 = num1 / 100;
if ((num1 >= 100) && (num1 <= 999))
{
    Console.WriteLine(num1 % 10);
}
else if ((num1 >= 1000) && (num1 <= 9999))
{
    Console.WriteLine(num2 % 10);
}
else if ((num1 >= 10000) && (num1 <= 100000))
{
    Console.WriteLine(num3 % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
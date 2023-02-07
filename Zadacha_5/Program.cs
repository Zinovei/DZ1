//Напишите программу , которая принемает на вход трех значное число
// и выдает вторую цифру этого числа .
Console.Write("Введите число от 100 до 999: ");
int num = int.Parse(Console.ReadLine()!);
int a = num / 10;
int b = a % 10;
Console.WriteLine(b);
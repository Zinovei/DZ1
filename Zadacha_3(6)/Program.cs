//Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите любое число ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();

if (n % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}
Console.WriteLine();
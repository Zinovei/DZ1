// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является лионо палиндромом.

Console.Write("Введите пятизначное число  ");
int num = int.Parse(Console.ReadLine()!);

if(num > 9999 && num <= 99999) 
{
    int a = num / 10000;
    int b = num % 10;

    if (a == b)
    {
        int c = num / 1000 % 10;
        int d = num % 100 / 10;

        Console.WriteLine("Да , число является палиндромным "); 
    }
    else 
    {
        Console.WriteLine("Нет , число не является палиндромным");
    }
 }
else
{
     Console.WriteLine("Такого числа нет , введите пятизначное число  ");
}
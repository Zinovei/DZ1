//Напишите программу, которая выдает третью цифру или сообщает, что цифры нет.
Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);

if(num > 99)
{
    while(num > 999)
    {
        num = num / 10;
    }
    int a = num % 10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Третей цифры нет!");
}
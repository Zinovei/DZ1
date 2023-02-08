//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
Console.WriteLine("Ведите значение от 1 до 7: ");
int n = int.Parse(Console.ReadLine()!);
if(n == 6 || n == 7)
    {
        Console.WriteLine("Да");
    }
else if (n <1 || n > 7)
    {
        Console.WriteLine("Число не распознано");
    }
else
{
    Console.WriteLine("Нет");
}
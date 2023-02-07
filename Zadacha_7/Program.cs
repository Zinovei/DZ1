//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
Console.WriteLine("Ведите значение от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);
    if(number == 1)
    {
        Console.WriteLine("Нет");
    }
    else if(number == 2)
    {
        Console.WriteLine("Нет");
    }
    else if(number == 3)
    {
        Console.WriteLine("Нет");
    }
    else if(number == 4)
    {
        Console.WriteLine("Нет");
    }
    else if(number == 5)
    {
        Console.WriteLine("Почти");
    }
    else if(number == 6)
    {
        Console.WriteLine("Да!");
    }
    else if(number == 7)
    {
        Console.WriteLine("Да(");
    }
    else
    Console.WriteLine("Введите другое число");
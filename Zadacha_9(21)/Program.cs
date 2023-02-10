// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.

Console.Write("Введите координату X1: ");
double X1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату Z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату X2: ");
double X2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату Z2: ");
double Z2 = Convert.ToDouble(Console.ReadLine()!);

double a = Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2,2) + Math.Pow(Z1 - Z2,2);

double sum = Math.Sqrt(a);

// Console.WriteLine(Math.Round(sum,2));
Console.WriteLine($"{sum:f2}");
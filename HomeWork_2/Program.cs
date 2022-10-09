// Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
Console.Clear();
Console.Write("Напишите координату A точки 1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите координату B точки  точки 1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите координату C точки  точки 1: ");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите координату A точки 2: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите координату B точки  точки 2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите координату C точки  точки 2: ");
int c2 = Convert.ToInt32(Console.ReadLine());

int A = a2 - a1;
int B = b2 - b1;
int C = c2 - c1;

double length = (Math.Round(Math.Sqrt(A * A + B * B + C * C), 3)); // + Использовал Math.Round 
Console.WriteLine($"Расстояние между точками {length}");
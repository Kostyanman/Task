﻿//             Напишите программу, которая принимает на вход
//             координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите кординаты точки А: ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты точки B: ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double dist = GetDistance3D(x1, y1, z1, x2, y2, z2);
double distRound = Math.Round(dist, 2, MidpointRounding.ToZero); //метод-функция округления dist до двух знаков
Console.WriteLine($"Расстояние между точками {distRound}");

double GetDistance3D(int a1, int a2, int a3, int b1, int b2, int b3)
{
    double firstCatet = b1 - a1;
    double secondCatet = b2 - a2;
    double thirdCatet = b3 - a3;
    double distance = Math.Sqrt(firstCatet * firstCatet + secondCatet * secondCatet + thirdCatet * thirdCatet);
    return distance;
}
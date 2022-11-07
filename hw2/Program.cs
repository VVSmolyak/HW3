﻿//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите координаты точки A: ");

int xa = int.Parse (Console.ReadLine()!);
int ya = int.Parse (Console.ReadLine()!);
int za = int.Parse (Console.ReadLine()!);

Console.WriteLine ("Введите координаты точки B: ");
int xb = int.Parse (Console.ReadLine()!);
int yb = int.Parse (Console.ReadLine()!);
int zb = int.Parse (Console.ReadLine()!);

double distance = Math.Sqrt (Math.Pow ((xb-xa),2) + (Math.Pow ((yb-ya),2) + (Math.Pow ((zb-za),2))));
Console.WriteLine (distance);
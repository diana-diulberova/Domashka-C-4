﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в которую нужно возвести число:");
int degree = Convert.ToInt32(Console.ReadLine());

int userNumberDegree = userNumber;

for(int i = 1; i < degree; i++)
{
    userNumberDegree = userNumberDegree * userNumber;
    Console.WriteLine(userNumberDegree);
}

Console.WriteLine($"{userNumber} в степени {degree} равно {userNumberDegree}");
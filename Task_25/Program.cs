﻿/*
  Задача 25.
  Напишите цикл, который принимает на вход два числа(A и B) и возводит число А в натуральную степень В.
  3, 5 -> 243
  2, 4 -> 16
*/

int Exponentiation (int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i ++)
    {
        result = result * numberA;
    }
    return result;
}

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32 (Console.ReadLine());

int exponentiation = Exponentiation (numberA, numberB);
Console.WriteLine (exponentiation);

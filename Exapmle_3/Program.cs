﻿
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


int namber = int.Parse(Console.ReadLine());

if (namber % 2 == 0) {
    Console.WriteLine("Число чётное.");
} else {
    Console.WriteLine("Число не чётное.");
}
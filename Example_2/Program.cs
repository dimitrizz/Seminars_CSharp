
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int namberA = int.Parse(Console.ReadLine());
int namberB = int.Parse(Console.ReadLine());
int namberC = int.Parse(Console.ReadLine());

int max = 0;


if (namberA > namberB) {
    max = namberA;
} else {
    max = namberB;
}

if (max > namberC) {
    Console.WriteLine(max);
} else {
    max = namberC;
    Console.WriteLine(max);
}




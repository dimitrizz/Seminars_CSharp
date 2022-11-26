
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int namberA = int.Parse(Console.ReadLine());
int namberB = int.Parse(Console.ReadLine());

if (namberA > namberB) {
    Console.WriteLine("Число " + namberA + " больше, а число " + namberB + " меньше.");
} else {
   Console.WriteLine("Число " + namberB + " больше, а число " + namberA + " меньше."); 
}

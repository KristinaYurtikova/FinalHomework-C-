// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine()!);

void NumbersFromNTo1(int numberN)
{
    if (numberN < 1)
        return;
    NumbersFromNTo1(numberN - 1);
    Console.Write(numberN + " ");
}

NumbersFromNTo1(numberN);
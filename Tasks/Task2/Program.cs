// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число М:");
int numberM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine()!);

int SumFromMToN(int numberM, int numberN)
{
    int sum=0;
    if (numberM == numberN)
    {
        return numberM;
    }
    sum += numberN;
    return SumFromMToN(numberM, numberN - 1) + sum;
}
Console.WriteLine($"Сумма чисел от {numberM} до {numberN} = {SumFromMToN(numberM, numberN)}");
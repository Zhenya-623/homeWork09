// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа число:");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


if (m > n)
{
    Console.WriteLine("Число М не может быть больше N");
}
else
{
    int sum = SumNaturalBeetwenNumbers(n, m);
    Console.WriteLine(sum);
}

int SumNaturalBeetwenNumbers(int numN, int numM)
{
    if (numN < numM) return 0;
    int sum = SumNaturalBeetwenNumbers(numN - 1, numM);
    return sum += numN;
}

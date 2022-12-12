// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа число:");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


int sum = SumNaturalBeetwenNumbers(m, n);
Console.Write(sum);

int SumNaturalBeetwenNumbers(int num1, int num2)
{
    int sum = num1;
    if (num1 > num2)
        return sum = sum + SumNaturalBeetwenNumbers(num1 - 1, num2);
    if (num1 < num2)
        return sum = sum + SumNaturalBeetwenNumbers(num1 + 1, num2);
    else return sum;
}



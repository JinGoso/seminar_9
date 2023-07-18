Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void SumNumber(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма равна: {sum}");
        return;
    }
    sum = sum + (numberM++);
    SumNumber(numberM, numberN, sum);
}
SumNumber(numberM, numberN, 0);
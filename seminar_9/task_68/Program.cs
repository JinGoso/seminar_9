int m = InputNumbers("Введите число M: ");
int n = InputNumbers("Введите число N: ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int FunctionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {FunctionAkkerman}");
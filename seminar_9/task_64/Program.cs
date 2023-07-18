Console.Write("Введите натуральное число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int number)
{
    if (number < 0) Console.Write($"{number} не натульное");
    
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NaturalNumber(number - 1);
}

NaturalNumber(number);
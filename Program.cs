// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double NumberPow (int P1, int P2)
{
    double x = Math.Pow(P1, P2);
    return x;
}

Console.Write("Введите число A: ");
int P1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int P2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Первое число в степени второго числа = {NumberPow(P1, P2)}");

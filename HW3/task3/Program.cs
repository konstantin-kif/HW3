// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

void TableCubes(int N)
{
    for (int k = 0; k <= N; k++)
    {
    Console.WriteLine(k * k * k + " ");
    }
}

int N = Prompt("Введите число N: ");
Console.WriteLine($"Таблица кубов от 1 до {N}:");
TableCubes(N);

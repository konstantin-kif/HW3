// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
void TabulaCubes(int num)
{
    for (int i = 0; i <= num; i++)
    {
    Console.WriteLine(i * i * i + " ");
    }
}
int numb = Prompt("Введите число: ");
Console.WriteLine($"Таблица кубов от 1 до {numb}:");
TabulaCubes(numb);

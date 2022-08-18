// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    Console.Write(message);
    string result = Console.ReadLine();
    return int.Parse(result);
}

// реверс числа 123 => 231
int ReverseNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        int variable = number % 10;
        number = number / 10;
        result = result * 10 + variable;
    }
    return result;
}

// Проверка на палиндром
bool CheckPalindrome(int value1, int value2)
{
    if (value1 == value2)
    {
        return true;
    }
    return false;
}

int number1 = Prompt("Введите число: ");
int number2 = ReverseNumber(number1);
bool isPalindrome = CheckPalindrome(number1, number2);
if (isPalindrome)
{
    Console.WriteLine($"Число {number1} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number1} не является палиндромом");
}
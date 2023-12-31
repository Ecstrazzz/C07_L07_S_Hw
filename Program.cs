// Знакомство с языками программирования (семинары)

// Урок 7. Рекурсия

// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от M до N. Использовать рекурсию, не использовать циклы.

// Пример:  M = 1; N = 5 -> "1, 2, 3, 4, 5"
//          M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Решение:

int Number()
{
    if (int.TryParse(Console.ReadLine(), out int inputNum))
    {
        if (inputNum <= 0)
        {
            Console.WriteLine("Неверный ввод");
            Environment.Exit(0);
        }
    }
    else
    {
        Console.WriteLine("Это не число!");
        Environment.Exit(0);
    }
    return inputNum;
}

Console.WriteLine("Введите первое число");
int startNum = Number();
Console.WriteLine("Введите второе число");
int finalNum = Number();

// Console.WriteLine("start=" + startNum + " end=" + finalNum);

int tempNum;
if (startNum > finalNum)
{
    tempNum = startNum;
    startNum = finalNum;
    finalNum = tempNum;
}

Console.Write("[");
PrintNumbers(startNum, finalNum);

void PrintNumbers(int first, int final)
{
    if (first == final)
    {
        Console.Write(first + "]");
        return;
    }
    else
    {
        Console.Write($"{first}, ");
    }

    PrintNumbers(first + 1, final);
}
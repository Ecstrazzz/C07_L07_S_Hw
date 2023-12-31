// Знакомство с языками программирования (семинары)

// Урок 7. Рекурсия

// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от M до N. Использовать рекурсию, не использовать циклы.

// Пример:  M = 1; N = 5 -> "1, 2, 3, 4, 5"
//          M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Решение:

// int Number()
// {
//     if (int.TryParse(Console.ReadLine(), out int inputNum))
//     {
//         if (inputNum <= 0)
//         {
//             Console.WriteLine("Неверный ввод");
//             Environment.Exit(0);
//         }
//     }
//     else
//     {
//         Console.WriteLine("Это не число!");
//         Environment.Exit(0);
//     }
//     return inputNum;
// }

// Console.WriteLine("Введите первое число");
// int startNum = Number();
// Console.WriteLine("Введите второе число");
// int finalNum = Number();

// // Console.WriteLine("start=" + startNum + " end=" + finalNum);

// int tempNum;
// if (startNum > finalNum)
// {
//     tempNum = startNum;
//     startNum = finalNum;
//     finalNum = tempNum;
// }

// Console.Write("[");
// PrintNumbers(startNum, finalNum);

// void PrintNumbers(int first, int final)
// {
//     if (first == final)
//     {
//         Console.Write(first + "]");
//         return;
//     }
//     else
//     {
//         Console.Write($"{first}, ");
//     }

//     PrintNumbers(first + 1, final);
// }

// -----------------------------------------------

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два неотрицательных
// числа m и n.

// Пример: m = 2, n = 3 -> A(m,n) = 29

// Решение:

uint Number()
{
    if (uint.TryParse(Console.ReadLine(), out uint inputNum))
    {
        
        if (inputNum < 0)
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

Console.WriteLine("Введите число m");
uint firstNum = Number();
Console.WriteLine("Введите число n");
uint secondNum = Number();

Console.Write($"A({firstNum},{secondNum}) = {Akkerman(firstNum, secondNum)}");

// Не могу понять в чём проблема
// выше A(4,0) или A(3,11) не считает

// Введите число m = 4   |  Введите число m = 3
// Введите число n = 1   |  Введите число n = 12
//
// Stack overflow.       |  Stack overflow.
// Repeat 13776 times:   |  Repeat 19285 times

uint Akkerman(uint first, uint second)
{
    uint result;
    if (first == 0)
    {
        result = second + 1;
    }
    else if (second == 0)
    {
        result = Akkerman(first - 1, 1);
    }
    else
    {
        result = Akkerman(first - 1, Akkerman (first, second - 1));
    }
    return result;
}
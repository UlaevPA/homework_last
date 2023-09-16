﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine("Введите натуральное число M");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1 || number2 < 1)
{
    System.Console.WriteLine("Некорректный ввод!");
    return;
}

AkkermanFunctions(number1, number2);


int AkkermanFunctions(int num1, int num2)
{
    if(num1 == 0) return num2 +1;
    else if (num2 == 0) return AkkermanFunctions(num1 - 1, 1);
    else return AkkermanFunctions(num1-1, AkkermanFunctions(num1, num2-1));
}

Console.WriteLine(AkkermanFunctions(number1, number2));
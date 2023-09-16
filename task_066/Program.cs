// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




Console.WriteLine("Введите натуральное число M");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int number2 = Convert.ToInt32(Console.ReadLine());



int SumNumberElem(int num1, int num2)
{
   if (num1 == 0) return (num2 * (num2 + 1)) / 2;            
    else if (num2 == 0) return (num1 * (num1 + 1)) / 2;       
    else if (num1 == num2) return num1;                       
    else if (num1 < num2) return num2 + SumNumberElem(num1, num2 - 1); 
    else return num2 + SumNumberElem(num1, num2 + 1);     
}
SumNumberElem(number1, number2);

Console.WriteLine(SumNumberElem(number1, number2));
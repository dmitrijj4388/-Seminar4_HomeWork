// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
int exp(int number1, int number2)
{
  int result = 1;    
    for (int i = 1; i <= number2; i++)
    {
    result = result*number1;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите число А и B: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int result = exp(a, b);
Console.WriteLine($"{a} в степени {b} = {result}");
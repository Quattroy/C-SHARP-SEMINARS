// 16. Напишите программу, которая принимает на вход 2 числа и проверяет, 
//является ли одно число квадратом другого

Console.Write("Введите первое целое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number2 = int.Parse(Console.ReadLine());

bool result = (number1 == number2 * number2) || (number2 == number1 * number1);

if (result)
{
Console.WriteLine($"{number1}, {number2} -> ДА");
}
else
{
Console.WriteLine($"{number1}, {number2} -> НЕТ");
}
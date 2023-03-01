Console.WriteLine("Введите первое число");
double firstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
double secondNumber = double.Parse(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    Console.WriteLine($"{firstNumber}, {secondNumber} -> кратно");
}
else
{
    Console.WriteLine($"{firstNumber}, {secondNumber} -> не кратно, отстаток {firstNumber % secondNumber}");
}
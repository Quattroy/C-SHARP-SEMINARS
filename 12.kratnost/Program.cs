Console.WriteLine("Введите первое число");
double firstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
double secondNumber = double.Parse(Console.ReadLine());

if(firstNumber % secondNumber ==0)
{
    Console.WriteLine("Второе число является кратным первому");
}
else
{
    Console.WriteLine(firstNumber % secondNumber);
}
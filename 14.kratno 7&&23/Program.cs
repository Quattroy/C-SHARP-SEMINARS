//14. Напишите программу, которая принимает на вход число и проверяет, 
//крато ли оно одновременно 7 и 23

Console.WriteLine("Введите число");
double Number = double.Parse(Console.ReadLine());


if (Number % 7 == 0 && Number % 23 == 0)
{
    Console.WriteLine($"{Number} -> кратно 7 и 23");
}
else
{
    Console.WriteLine($"{Number} -> не кратно, 7 и 23");
}

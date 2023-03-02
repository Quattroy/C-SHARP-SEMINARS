// -------------------------- Начало программы ----------------------------------
Console.Clear();
double x1 = 0, x2 =0, y1 = 0, y2 =0;
InitCoordinatesByUser(ref x1, ref x2, ref y1, ref y2); // Вызов метода с передачей параметров по ссылке (ref)
                                                     // Вызов метода с передачей параметров по значению


static void InitCoordinatesByUser(ref double x1, ref double  x2, ref double y1, ref double y2)
{
    try
    {
        Console.Write("Введите X1: ");
        x1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите X2: ");
        x2 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y1: ");
        y1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y2: ");
        y2 = double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
// -----------------------------------------------------------------------------
// Определяем функцию, принимающую два аргумента (координаты точки x и y)
// и выводящую в консоль номер четверти плоскости, в которой находится эта точка



double a = (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double b = Math.Sqrt(a);
Console.WriteLine($"Расстояние между точками = {b}");


// ---------------------- Конец определения методов ----------------------------

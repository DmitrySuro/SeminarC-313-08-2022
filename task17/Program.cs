

System.Console.Clear();



int GetNumberOfPlane(double x, double y)
{
    int numberOfPlane = -1;
if (x > 0 && y > 0)
    numberOfPlane = 1;
if (x < 0 && y > 0)
    numberOfPlane = 2;
if (x < 0 && y < 0)
    numberOfPlane = 3;
if (x > 0 && y < 0)
    numberOfPlane = 4;

return numberOfPlane;
}

System.Console.WriteLine("Введите x");
double x = double.Parse(System.Console.ReadLine()!);
System.Console.WriteLine("Введите y");
double y = double.Parse(System.Console.ReadLine()!);

int numberOfPlane = GetNumberOfPlane(x, y);
if (numberOfPlane == -1)
System.Console.WriteLine("вы ввели некоректные координаты");
else
System.Console.WriteLine($"Номер плоскости {numberOfPlane}.");
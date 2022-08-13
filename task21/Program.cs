
// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

System.Console.Clear();

double DistanceCoordin(double x1, double y1, double x2, double y2)
{
    double differenceX = Math.Abs(x1 - x2);
    double differenceY = Math.Abs(y1 - y2);
    double result = Math.Sqrt(differenceX * differenceX + differenceY * differenceY);
return result;
}

System.Console.WriteLine("Введите первую координату точки А ");
double x1 = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите вторую координату точки А ");
double y1 = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите первую координату точки В ");
double x2 = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите вторую координату точки B ");
double y2 = double.Parse(System.Console.ReadLine()!);

double distance = DistanceCoordin(x1, y1, x2, y2);

System.Console.WriteLine($"Расстояние: {distance:f2}");
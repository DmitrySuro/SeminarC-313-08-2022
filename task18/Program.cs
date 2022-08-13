//Напишите программу, которая по заданному 
//номеру четверти, показывает диапазон возможных координат 
//точек в этой четверти (x и y

System.Console.Clear();


string GetRange (int numberOfPlane)
{
    string range = "Error";
    if(numberOfPlane == 1)
        range = "x > 0, y > 0";
    if(numberOfPlane == 2)
        range = "x < 0, y > 0";
    if(numberOfPlane == 3)
        range = "x < 0, y < 0";
    if(numberOfPlane == 4)
        range = "x > 0, y < 0";
    return range;
}


System.Console.WriteLine("Введите номер плоскости");
int numberOfPlane = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine($"Ваш диапозон: {GetRange(numberOfPlane)}");
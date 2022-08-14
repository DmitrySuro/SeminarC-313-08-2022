//Задача 26: Напишите программу, которая принимает на 
//вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

System.Console.Clear();

int NumbersOfNumbers (int numberUser)
{
 int count = 0;
 while (numberUser > 0)
 {
    numberUser /= 10;
    count++;
 }
return count;
}

System.Console.WriteLine("Введите Ваше число");
int numberUser = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine($"Вот количество цифр в вашем числе: {NumbersOfNumbers(numberUser)}");



//int GetSumFrom1ToA(int numberA)
//{
  //  int sum = 0;
    //for (int i = 1; i <= numberA; i++)
    //{
      //  sum += i;
    //}
    //return sum;
//}

int Getsum(int numberA)
{
    return numberA * (numberA + 1) / 2;
}


System.Console.WriteLine("Введите число");
int numberA = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine(Getsum(numberA));

﻿//Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]



System.Console.Clear();


int[] RandomNumbersArray(int size)
{
    int[] numbersArray = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        numbersArray[i] = rnd.Next(2);
    }
    return numbersArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int size = 8;
int[] array = NumbersArray(size);
PrintArray(array);
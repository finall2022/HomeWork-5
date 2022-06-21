/* Задача 1: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве. */

Console.Write("Введите количество элементов массива: ");
string iNum = Console.ReadLine();
int Num = int.Parse(iNum);
Random rndNum = new Random();
int[] arrNum = new int[Num];
int i = 0;
int count = 0;
for (i = 0; i < Num; i++) //заполняем массив
{
    int num = rndNum.Next(100, 1000);
    arrNum[i] = num;
    Console.Write($"{arrNum[i]} | ");

    if (arrNum[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество элементов в массиве - {Num}, из них чётных - {count} ");

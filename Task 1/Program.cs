/* Задача 1: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве. */

Random rndNum = new Random();
Random rndLenght = new Random();
int lenght = rndLenght.Next(2, 11);
int[] arrNum = new int[lenght];
int i = 0;
int count = 0;
for (i = 0; i < lenght; i++) //заполняем массив
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
Console.WriteLine($"Количество элементов в массиве - {lenght}, из них чётных - {count} ");

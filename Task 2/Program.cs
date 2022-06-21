/* Задача 2: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих на 
нечётных позициях. */

Random rndNum = new Random();
Random rndLenght = new Random();
int lenght = rndLenght.Next(2,25);
int[] arr = new int[lenght];
int i = 0;
int sum = 0;
Console.WriteLine($"ЭМ      поз  ");
for (i = 0; i < lenght; i++)
{
    int num = rndNum.Next(1000);
    arr[i] = num;
    Console.WriteLine($"{arr[i]}     {i+1}");
    if (i % 2 == 0) 
    {
        sum = sum + arr[i];
    }

}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
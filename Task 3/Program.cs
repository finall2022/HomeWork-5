/* Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов 
массива. */
int getMin(int[] arrTemp) //Функция поиска минимального элемента массива
{
    int index = 0;
    int minTemp = arrTemp[0];
    int lenghtTemp = arrTemp.Length;
    while (index < lenghtTemp)
    {
        if (minTemp > arrTemp[index])
        {
            minTemp = arrTemp[index];
        }
        index++;
    }
    return minTemp;
}

int getMax(int[] arrTemp) //Функция поиска максимального элемента массива
{
    int index = 0;
    int maxTemp = arrTemp[index];
    int lenghtTemp = arrTemp.Length;
    while (index < lenghtTemp)
    {
        if (maxTemp < arrTemp[index])
        {
            maxTemp = arrTemp[index];
        }
        index++;
    }
    return maxTemp;
}

Random rndNum = new Random();
Random rndLenght = new Random();
int lenght = rndLenght.Next(2, 25);
int[] arr = new int[lenght];
int i = 0;
int max = 0;
int min = 0;
int result = 0;
for (i = 0; i < lenght; i++) // Заполняем массив
{
    int num = rndNum.Next(1000);
    arr[i] = num;
    
    Console.WriteLine($"{arr[i]}({i}) ");

}
Console.WriteLine("");
//Вызов функций для нахождения минимального и максимального элементов массива
max = getMax(arr);
min = getMin(arr);
Console.WriteLine($"{max} - максимальный элемент");
Console.WriteLine($"{min} - минимальный элемент");
result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result}");
Console.WriteLine(" ");
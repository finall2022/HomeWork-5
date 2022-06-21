/*  Задача 1: Напишите программу, которая принимает 
на вход число и проверяет, является ли оно 
палиндромом.
 */

//функция для определения палиндрома
int Pal(int[] arrTemp)
{
    int i = 0;
    int count = 0;
    int lenghtTemp = arrTemp.Length;
    Console.WriteLine(lenghtTemp);
    while (i < lenghtTemp)
        if (arrTemp[i] == arrTemp[lenghtTemp - 1])
        {
            i++;
            lenghtTemp--;
            count++;
            Console.WriteLine($"i = {i}, lenghtTemp = {lenghtTemp}, count = {count}");
        }
    return count;
}
Console.Write("Введите число: "); //вводим число
string istring = Console.ReadLine(); //считываем число
int inum = int.Parse(istring);
int lenght = istring.Length; //определяем размер массива
int[] arr = new int[lenght]; //инициализируем массив с размером lenght
int index = lenght - 1;
Console.WriteLine($"Число состоит из {lenght} разрядов");
Console.WriteLine($"Ц(и)");
Console.WriteLine($"====");
while (index >= 0 && index < lenght) //заполняем массив цифрами числа
{
    arr[index] = inum % 10;

    inum = inum / 10;

    Console.WriteLine($"{arr[index]}({index})");
    index--;
}

int c = Pal(arr);
if (c % 2 == 0)
{
    Console.Write("палиндром");
}
else
{
    Console.Write("не палиндром");
}
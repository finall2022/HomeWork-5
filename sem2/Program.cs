/*  Задача 1: Напишите программу, которая принимает 
на вход число и проверяет, является ли оно 
палиндромом.
 */

/* Уважаемый Владимир. Спасибо за семинары и обратную связь. 
А вот эта задача очень помогла разобраться и с массивами
и особенно с функциями, т.к. обычно спотыкался именно на них и 
дальше дело не шло, надеюсь это переломный момент :)
по-моему всё работает :) может, конечно, не совсем красиво.
 */
//функция для определения палиндрома
int Pal(int[] arrTemp)
{
    int i = 0;
    int count = 0;
    int lenghtTemp = arrTemp.Length;
    while (i < lenghtTemp)
        if (arrTemp[i] == arrTemp[lenghtTemp - 1])
        {
            //Console.WriteLine($"i = {i}, lenghtTemp = {lenghtTemp}, count = {count}");
            i++;
            lenghtTemp--;
        }
        else
        {
            count++;  //счетчик увеличивается, если условие не выполнено, т.е. одна из пар цифр не совпала
            return count;
        }
    return count;
}

Console.Write("Введите число: "); //вводим число
string istring = Console.ReadLine(); //считываем число
int inum = int.Parse(istring);
int lenght = istring.Length; //определяем размер массива
int[] arr = new int[lenght]; //инициализируем массив с размером lenght
int index = lenght - 1;
/* Console.WriteLine($"Число состоит из {lenght} разрядов");
Console.WriteLine($"Ц(и)");
Console.WriteLine($"===="); */

while (index >= 0 && index < lenght) //заполняем массив 
{
    arr[index] = inum % 10;
    inum = inum / 10;
    //Console.WriteLine($"{arr[index]}({index})");
    index--;
}

int c = Pal(arr); /*вызываем функцию, передаем массив в виде аргумента
получаем результат в переменную */
if (c == 0) //значит условие цикла выполнено
{
    Console.Write($"Число {istring} является палиндромом");
}
else
{
    Console.Write($"Число {istring} не является палиндромом");
}
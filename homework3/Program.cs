Console.Write("Введите день недели :");
int a = Convert.ToInt32(Console.ReadLine());
 if (a >= 1 && a <= 7)
{
    if (a == 6 || a == 7) Console.WriteLine("Сегодня выходной");
    else Console.WriteLine("Сегодня рабочий день");
}
else Console.WriteLine("Неверное число");
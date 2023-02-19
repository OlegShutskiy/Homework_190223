int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000)
{
    Console.WriteLine((a % 100) / 10);
}
else
{
    Console.WriteLine("ERROR");

}
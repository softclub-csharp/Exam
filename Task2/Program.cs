System.Console.Write("from: ");
int from = Convert.ToInt32(Console.ReadLine());

System.Console.Write("To: ");
int to = Convert.ToInt32(Console.ReadLine());

while (from <= to)
{
    for (int i = 1; i <= 10; i++)
    {
        System.Console.WriteLine($"{from}*{i}={from * i}");
    }
    System.Console.WriteLine();
    from++;
}
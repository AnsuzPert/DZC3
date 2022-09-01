Console.WriteLine("ВВедите целое число");
int x = Convert.ToInt32(Console.ReadLine());
int tab;
for (int i=1; i<=x; i++)
{
    Console.Write($" {i*i*i}");
}
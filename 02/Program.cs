string nazv()
{
Console.WriteLine("ВВестите координату х первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВестите координату у первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВестите координату z первой точки ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВестите координату х второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВестите координату у второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВестите координату z второй точки ");
int z2 = Convert.ToInt32(Console.ReadLine());
double rast;
rast = Math.Round(Math.Sqrt(((x1-x2)*(x1-x2))+((y1-y2)*(y1-y2))+((z1-z2)*(z1-z2))),2);
return $"Расстояние между точками равно {rast}";
}
try
{
    Console.WriteLine(nazv());
}
catch
{
    Console.WriteLine("Какая-то ошибка");
}
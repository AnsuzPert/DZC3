Console.WriteLine("ВВедите целое пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());
if (x/10000==x%10) 
{if ((x/1000%10)==(x%100/10)) Console.WriteLine("да");
else Console.WriteLine("нет");
}
else Console.WriteLine("нет");
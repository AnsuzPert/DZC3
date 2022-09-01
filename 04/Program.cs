int sum=0;
int sumkv=0;
Console.WriteLine("ВВедите числа");
do
{
    int x = Convert.ToInt32(Console.ReadLine());
    sum = sum + x;
    sumkv = sumkv + (x*x);
}
while(sum!=0);
Console.WriteLine("Сумма квадратов равна " + sumkv);
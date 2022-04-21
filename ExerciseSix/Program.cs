Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a>=100 && a<=999)
{
    int b = a / 10;
    int c = b % 10;
    Console.WriteLine(c);
}
else
{
    Console.WriteLine("ТРЕХзначное число тебе знакомо?");
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a >=100 && a <=999)
{
    int b = a % 10;
    Console.WriteLine(b);
}
    if(a>=1000 && a<=9999)
    {
        int b = a / 10;
        int c = b % 10;
        Console.WriteLine(c);
    }
        if(a>=10000 && a<=99999)
        {
        int b = a / 10;
        int c = b / 10;
        int d = c % 10;
        Console.WriteLine(d);
        }
            if(a>=100000 && a<=999999)
            {
                int b = a / 10;
                int c = b / 10;
                int d = c / 10;
                int e = d % 10;
                Console.WriteLine(e);
            }
                if(a>=1000000 && a<=9999999)
                {
                    int b = a / 10;
                    int c = b / 10;
                    int d = c / 10;
                    int e = d / 10;
                    int f = e % 10;
                    Console.WriteLine(f);
                }
                    if(a<=99)
                    {
                        Console.WriteLine("Третьей цифры нет");
                    }
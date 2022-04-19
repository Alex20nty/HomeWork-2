int a = new Random().Next(10, 100);
Console.WriteLine(a);

int b = a % 10;
int c = a / 10;
int max;

if (b > c)
{
    max = b;
}
else
{
    max = c;
}

Console.WriteLine(max);



Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int c = a % b;

if(c == 0)
{
    Console.WriteLine(b+ " кратно "+a);
}
else
{
    Console.WriteLine(b+ " Не кратно "+a);
    Console.WriteLine("Остаток "+c);
}



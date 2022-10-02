//zadanie dop ne schitaet summu pravilno
Console.Clear();
Console.WriteLine("enter 3 numbers between 0 and 1000:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int count = 0;
void prostoe(int x, int count)
{
    count = 0;
    if (x == 2) { Console.WriteLine("prostoe"); count++; }
    if (x % 2 == 0) { Console.WriteLine("ne prostoe"); }
    for (int i = 3; i <= x / 2; i = i + 2)
    {
        if (x % i == 0) count++;
    }
    if (count == 0) Console.WriteLine("prostoe");
    else Console.WriteLine("ne prostoe");
}
int sum = 0;
prostoe(a, count);
if (count == 0) sum = sum + a;
prostoe(b, count);
if (count == 0) sum = sum + b;
prostoe(c, count);
if (count == 0) sum = sum + c;

Console.WriteLine(sum);

prostoe(sum, count);
if (count == 0) Console.WriteLine("summa prostoe");
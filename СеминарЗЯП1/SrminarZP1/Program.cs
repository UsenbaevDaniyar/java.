Console.Write("Введите первое число ");
int Fn = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int Sn = Convert.ToInt32(Console.ReadLine());

if (Fn == Sn * Sn)
{
    Console.WriteLine("a = " + Fn + ", b = " + Sn + " => yes");
}
else
{
    Console.WriteLine($"a = {Fn}, b = {Sn} => no");
}
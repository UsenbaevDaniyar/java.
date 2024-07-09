Console.Write("Введите первое число ");
int Firstnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int Secondnumber = Convert.ToInt32(Console.ReadLine());

if(Firstnumber % Secondnumber == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no, " + Firstnumber % Secondnumber);
}

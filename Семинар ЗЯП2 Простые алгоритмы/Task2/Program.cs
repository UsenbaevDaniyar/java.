Console.Write("Введите тркхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
    int digit = number / 10 % 10;
int result = 1;

for(int power = number % 10; power > 0; power --)
{
    result *= digit;
}
Console.WriteLine(result);
}
else{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
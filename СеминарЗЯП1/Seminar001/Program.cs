Console.Write("Введите трезначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number <1000)
{
    int FirstDigit = number / 100;
    int thirdDigit = number % 10;
    int sum = FirstDigit + thirdDigit;
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("ВВедено некоректное число!!!");
}
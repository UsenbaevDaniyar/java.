Console.Write("Введите тркхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
   // Console.Write(number / 100 + "" + number % 10);
   //int result = Convert.ToInt32(number / 100 + "" + number % 10);
   int  result = number / 100 * 10 + number % 10;
   Console.WriteLine(result);
}
else{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
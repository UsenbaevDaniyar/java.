Console.Write("Введите положительное число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)

{
Console.Write("Вы ввели некорректное число");
}

else{
int i = -number;
while(i <= number)
{
    Console.Write(i + " ");
    i++;
}
}

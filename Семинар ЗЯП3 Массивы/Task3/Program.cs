Console.Write("ВВедите размер массива: ");
int arraySise = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arraySise];
Random rand = new Random();
// Заполнение массива
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(10, 100);

}
// вывод массива
for (int i = 0; i < array.Length; i++)
{

 Console.Write(array[i] + " ");
}

Console.Write("\nВВедите искомое число: ");
int findNumber = Convert.ToInt32(Console.ReadLine());

bool numberIsFinded = false;

for(int i = 0; i < array.Length; i ++)
{
    if(array[i] == findNumber)
        numberIsFinded = true;
        break;
}

if(numberIsFinded)
    Console.WriteLine("yes");

else
Console.WriteLine("no");

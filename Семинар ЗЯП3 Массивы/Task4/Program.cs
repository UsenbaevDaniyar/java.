int[] array = new int[10];
Random rand = new Random();

// Заполнение массива
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);

}
// вывод массива
for (int i = 0; i < array.Length; i++)
{

 Console.Write(array[i] + "\t");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
     array[i] *= -1; //-array[i]; //array[i] * -1;
}

// вывод массива
for (int i = 0; i < array.Length; i++)
{

 Console.Write(array[i] + "\t");
}
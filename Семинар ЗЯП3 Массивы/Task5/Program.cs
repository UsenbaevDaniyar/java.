Random rand = new Random();

int[] array = new int[rand.Next(5, 16)];

// Заполнение массива
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
}
// вывод массива
// for (int i = 0; i < array.Length; i++)
// {
//  Console.Write(array[i] + "\t");
// }
// Console.WriteLine();

// вывод массива foreach
foreach(int number in array)
{
    Console.Write(number + " ");
}
Console.WriteLine();

int[] multPairs = new int[array.Length / 2];
for(int i = 0; i < array.Length / 2; i++)
{
    multPairs[i] = array[i] * array[array.Length - 1 - i];
}

foreach(int number in multPairs)
    Console.Write(number + " ");
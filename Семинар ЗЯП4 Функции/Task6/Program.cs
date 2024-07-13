// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3


void Main()
{
    int arraySise = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySise, 0, 20);
    PrintArray(array);
    Console.WriteLine(CountPrimary(array));
}
int CountPrimary(int[] array)

{
    int count = 0;
    
    foreach (int num in array)
        if(isPrimary(num))
        count++;

        return count;
    
}

bool isPrimary(int number)
{
    if(number < 2)
        return false;
    
    for(int i = 2; i <= Math.Sqrt(number); i++)
        if(number % i == 0)
            return false;

    return true;
}

 void PrintArray(int[] arrayForPrint)
{
     Console.WriteLine(string.Join(" ", arrayForPrint));
 }


 int[] GenerateArray(int Sise, int minvalue, int maxvalue)

{
    int[] TempArray = new int[Sise]; 
  Random rand = new Random();

    for(int i = 0; i < TempArray.Length; i++)
    TempArray[i] = rand.Next(minvalue, maxvalue + 1);
    return TempArray;

 }
 int ReadInt(string msg)
{
    Console.Write(msg);
   return Convert.ToInt32(Console.ReadLine());
    
}

Main();

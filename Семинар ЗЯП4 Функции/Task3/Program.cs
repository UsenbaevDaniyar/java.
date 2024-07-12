
void Main()
{
    int arraySise = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySise, 10, 100);
    PrintArray(array);
    Console.WriteLine(CountNumbers(array, 7, 1));
}

int CountNumbers(int[] arr, int div, int end)
{
    int count = 0;
    for(int i = 0; i <   arr.Length; i++)
        if(arr[i] % div == 0 && arr[i] % 10 == end)
            count++;

    return count;
}

void PrintArray(int[] arrayForPrint)
{
    for(int i  = 0; i < arrayForPrint.Length; i++)
    Console.Write(arrayForPrint[i] +  " ");

    Console.WriteLine();
}

int[] GenerateArray(int Sise, int minvalue, int maxvalue)

{
    int[] TempArray = new int[Sise]; 
    Random rand = new Random();

    for(int i = 0; i < TempArray.Length; i++)
    TempArray[i] = rand.Next(minvalue, maxvalue);
    return TempArray;

}

int ReadInt(string msg)
{
    Console.Write(msg);
   return Convert.ToInt32(Console.ReadLine());
    
}

Main();


void Main()
{
    int arraySise = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySise, 10, 100);
    PrintArray(array);
    Console.WriteLine(CountNumbers(array));

    int[] array2 = GenerateArray(20, 10, 1000);
    PrintArray(array2);
    Console.WriteLine(CountNumbers(array2));
}

int CountNumbers(int[] arr)
{
    int count = 0;
    for(int i = 0; i <   arr.Length; i++)
        if(arr[i] % 7 == 0 && arr[i] % 10 == 1)
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
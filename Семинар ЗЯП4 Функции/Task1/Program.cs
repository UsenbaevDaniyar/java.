
void Main()
{
    int arraySise = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySise, 0, 10);
    PrintArray(array);

    int[] array2 = GenerateArray(7, 10, 100);
    PrintArray(array2);
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

void Main()
{
    int arraySise = ReadInt("Введите размер массива: ");

    if(arraySise > 8 || arraySise < 1)
    {
        Console.Write("Введено некоректный размер массива");
        return;
    }
    int[] array = GenerateArray(arraySise, 0, 9);
    PrintArray(array);
    
    Console.WriteLine(fromArrayToNumber(array));
}

int fromArrayToNumber(int[] array)
{ int number = 0;
    for(int i = 0; i < array.Length; i++)
    {
        number *= 10;
        number += array[i];
    }
    return number;
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

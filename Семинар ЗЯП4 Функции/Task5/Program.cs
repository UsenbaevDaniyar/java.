
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

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
}

    // int result = Convert.ToInt32(string.Concat(array));
    
  int result = Convert.ToInt32(string.Join("", array));

//  Console.WriteLine(fromArrayToNumber(array));
// }

//  int fromArrayToNumber(int[] array)
//  { int number = 0;
//      for(int i = 0; i < array.Length; i++)
//      {
//          number *= 10;
//         number += array[i];
//      }
//     return number;
// }


void PrintArray(int[] arrayForPrint)
{
    Console.WriteLine(string.Join(", ", arrayForPrint));
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

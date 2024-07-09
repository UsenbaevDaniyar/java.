// 1 - й вариант заполнения массива
// int[] nums1 = {1, 2, 87, 9, 15, 7};

// 2 й вариант заполнения массива

// int[] nums2 = new int[4];

// for (int i = 0; i < nums2.Length; i++)
// {
//     Console.Write($"Введите {i +  1}-й элемент массива: ");
//     nums2[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i =0; i < nums2.Length; i++)
// Console.Write(nums2[i] + " ");

// 3 й вариант заполнения массива

// int[] nums3 = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
// for(int i =0; i < nums3.Length; i++)
// Console.Write(nums3[i] + " ");

// 4 й вариант заполнения массива
// int[] nums4 = new int[5];
// for(int i =0; i < nums4.Length; i++)
// {
//     nums4[i] = new Random().Next(0, 10);
// }

// for(int i =0; i < nums4.Length; i++)
// Console.Write(nums4[i] + " ");

// 4 й вариант заполнения массива для экономии памяти для генерации рандомных чисел выделяется только 1 ячейка памяти
int[] nums4 = new int[5];
Random rand = new Random();

for(int i =0; i < nums4.Length; i++)
{
    nums4[i] = rand.Next(0, 10);
}

for(int i =0; i < nums4.Length; i++)
Console.Write(nums4[i] + " ");
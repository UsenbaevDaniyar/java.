//int n = 10;
int[] array = {2, 5, 4, 10, 15, 228, 665, 55, 66, 96};
int i = 0;

while(i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;

}
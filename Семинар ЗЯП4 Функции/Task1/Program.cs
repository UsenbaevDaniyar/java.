
void Main()
{
    int value = ReadInt();
    Console.WriteLine(value);
}

// тип возвращаемого значения _имя функции(){}

int ReadInt()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Main();
void Main()
{
    string str = "textabc";

    char[] chars = str.ToCharArray();

    PrintCharArray(chars);

}

void PrintCharArray(char[] chars)
{
    Console.WriteLine(string.Join(", ", chars));
}

Main();
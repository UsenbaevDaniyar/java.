void Main()
{
    string str = "textabc";

    char[] chars = StringToCharArray(str);

    PrintCharArray(chars);

}

char[] StringToCharArray(string str)

{
    char[] chars = new char[str.Length];

    for(int i = 0; i < str.Length; i++)
    chars[i] = str[i];

    return chars;
}

void PrintCharArray(char[] chars)
{
    Console.WriteLine(string.Join(", ", chars));
}

Main();
void Main()
{
    char[] chars = {'a', 'b', 'c', 'd'};
    // 1-ый способ
    // string str = new string(chars);
    // Console.WriteLine(str);

    // Console.WriteLine(CharsToString(chars));
    // 3-й способ
    // Console.WriteLine(string.Join("", chars));
    // 4-й способ
    Console.WriteLine(string.Concat(chars));
}
// 2-й способ
// string CharsToString(char[] chars)

// {
//     string str = "12345";

//     foreach (char c in chars)
//         str += c;

//     return str;
// }

Main();
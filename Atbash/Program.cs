using System.Text;
string str = "abc";

Console.WriteLine(Encrypt(str));

string Encrypt(string word)
{
    StringBuilder sbResult = new StringBuilder();

    for (int i = 0; i < word.Length; i++)
    {
        sbResult.Append((char)((int)'z' - ((int)word[i] - (int)'a')));
    }

    return sbResult.ToString();
}
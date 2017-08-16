public int TitleToNumber(string s)
{
    int number = 0;
    for(int i = 0; i < s.Length; i++)
    {
        int factor = number * 26;
        int charVal = s[i] - 'A' + 1;
        number = factor + charVal;
    }
    return number;
}
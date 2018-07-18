public class Solution
{
    private const int TO_LOWER_CASE = 32;

    public string ToLowerCase(string str)
    {
        char[] charArr = str.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            char c = charArr[i];
            int asciiVal = (int)c;
            if(asciiVal >= 65 && asciiVal <= 122)
            {
                if ((asciiVal + TO_LOWER_CASE) <= (int)'z')
                {
                    charArr[i] = (char)(asciiVal + TO_LOWER_CASE);
                }
            }
        }
        return new string(charArr);
    }
}